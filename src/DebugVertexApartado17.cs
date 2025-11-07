using UnityEngine;
using System.Text;

public class DebugVertexApartado17 : MonoBehaviour
{
    public GameObject vertex;
    Camera cam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = GetComponent<Camera>();
        Vector4 pos = vertex.transform.localPosition;
        pos.w = 1;
        Debug.Log("Posición del vértice en local: " + pos);
        Debug.Log("Matriz de modelo: " + FormatMatrix(vertex.transform.parent.localToWorldMatrix));
        Vector4 worldPos = vertex.transform.parent.localToWorldMatrix * pos;
        Debug.Log("Posición del vértice en mundial: " + worldPos);
        Debug.Log("Matriz de vista: " + FormatMatrix(cam.worldToCameraMatrix));
        Vector4 viewPos = cam.worldToCameraMatrix * worldPos;
        Debug.Log("Posición del vértice respecto al ojo de la cámara: " + viewPos);
        Debug.Log("Matriz de proyección: " + FormatMatrix(cam.projectionMatrix));
        Vector4 clipCoords = cam.projectionMatrix * viewPos;
        Debug.Log("Posición del vértice respecto al clip de la cámara: " + clipCoords);
        Vector3 normalizedCoords = new Vector3(clipCoords.x / clipCoords.w, clipCoords.y / clipCoords.w, clipCoords.z / clipCoords.w);
        Debug.Log("Coordenadas normalizadas: " + normalizedCoords);
        Debug.Log("Posición del vértice en el viewport: " + new Vector3((normalizedCoords.x + 1) / 2, (normalizedCoords.y + 1) / 2, normalizedCoords.z));
//        Debug.Log("Posición del vértice respecto a la pantalla en píxeles: " + cam.ViewportToScreenPoint(cam.WorldToViewportPoint(normalizedCoords)));
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
