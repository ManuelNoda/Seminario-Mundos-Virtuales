using System.Text;
using UnityEngine;

public class ProjectionApartado8 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Camera cam = GetComponent<Camera>();
        Debug.Log(FormatMatrix(cam.previousViewProjectionMatrix));
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
