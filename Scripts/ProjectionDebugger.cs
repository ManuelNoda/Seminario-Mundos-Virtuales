using UnityEngine;
using System.Text;

public class ProjectionDebugger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Camera cam = Camera.main;

        if (cam.orthographic)
        {
            Debug.Log("📐 Matriz de proyección ortográfica:");
            Matrix4x4 matrix = cam.projectionMatrix;
            Debug.Log(FormatMatrix(matrix));
        }
        else
        {
            Debug.Log("🎥 La cámara no es ortográfica. Modo actual: Perspectiva");
        }
    }

    // Update is called once per frame
    void Update()
    {

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
