using UnityEngine;
using System.Text;

[RequireComponent(typeof(Camera))]
public class ViewMatrixDebugger : MonoBehaviour
{
    private Matrix4x4 previousView;

    void Start()
    {
        previousView = Camera.main.worldToCameraMatrix;
        Debug.Log("▶️ Matriz de vista inicial:\n" + FormatMatrix(previousView));
        Debug.Log("Nota: worldToCameraMatrix = inverse(camera.transform.localToWorldMatrix)");
    }

    void Update()
    {
        Camera cam = Camera.main;
        Matrix4x4 currentView = cam.worldToCameraMatrix;

        if (!MatricesIguales(currentView, previousView))
        {
            Debug.Log("🔁 Matriz de vista actualizada (después de rotación/traslación):\n" + FormatMatrix(currentView));

            // Comprobación opcional: producto = identidad
            Matrix4x4 check = currentView * cam.transform.localToWorldMatrix;
            Debug.Log("🔎 worldToCameraMatrix * localToWorldMatrix (debería ser identidad):\n" + FormatMatrix(check));

            previousView = currentView;
        }
    }

    bool MatricesIguales(Matrix4x4 a, Matrix4x4 b, float tol = 1e-4f)
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
