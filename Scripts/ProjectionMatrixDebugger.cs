using UnityEngine;
using System.Text;

[RequireComponent(typeof(Camera))]
public class ProjectionMatrixDebugger : MonoBehaviour
{
  private Camera cam;
  private bool previousOrtho;
  private Matrix4x4 previousProjection;

  void Start()
  {
    cam = GetComponent<Camera>();
    previousOrtho = cam.orthographic;
    previousProjection = cam.projectionMatrix;
    PrintProjection("📷 Matriz inicial (" + (cam.orthographic ? "Ortográfica" : "Perspectiva") + ")");
  }

  void Update()
  {
    // Permitir cambiar entre modos con tecla C
    if (Input.GetKeyDown(KeyCode.C))
    {
      cam.orthographic = !cam.orthographic;
      PrintProjection("🔁 Cambio a " + (cam.orthographic ? "Ortográfica" : "Perspectiva"));
    }

    if (previousOrtho != cam.orthographic || !MatricesIguales(cam.projectionMatrix, previousProjection))
    {
      PrintProjection("🔄 Matriz de proyección actualizada");
      previousProjection = cam.projectionMatrix;
      previousOrtho = cam.orthographic;
    }
  }

  void PrintProjection(string title)
  {
    Debug.Log($"{title}:\n" + FormatMatrix(cam.projectionMatrix));
  }

  bool MatricesIguales(Matrix4x4 a, Matrix4x4 b, float tol = 1e-5f)
  {
    for (int i = 0; i < 16; i++)
      if (Mathf.Abs(a[i] - b[i]) > tol) return false;
    return true;
  }

  string FormatMatrix(Matrix4x4 m)
  {
    StringBuilder sb = new StringBuilder();
    sb.AppendLine("\n┌──────────────────┐");

    for (int i = 0; i < 4; i++)
    {
      sb.Append("│ ");
      for (int j = 0; j < 4; j++)
      {
          sb.Append($"{m[i, j],8:F4} ");
      }
      sb.AppendLine("│");
    }

    sb.AppendLine("└──────────────────┘");
    return sb.ToString();
  }
}
