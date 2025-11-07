using System.Text;
using UnityEngine;

public class MostrarMatricesApartado13 : MonoBehaviour
{
    public GameObject capsule;
    Camera cam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = GetComponent<Camera>();
        Debug.Log("Matriz de modelo de la cápsula: " + FormatMatrix(capsule.transform.localToWorldMatrix));
        Debug.Log("Matriz de vista: " + FormatMatrix(cam.worldToCameraMatrix));
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
