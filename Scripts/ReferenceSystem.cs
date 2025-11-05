using UnityEngine;
using System.Text;

public class ReferenceSystem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1) Origen local en coordenadas mundiales
        Vector3 origenWorld = transform.position;
        Debug.Log($"📍 Origen (transform.position): {origenWorld}");

        // 2) Ejes locales en coordenadas mundiales
        Vector3 ejeX_world = transform.right;
        Vector3 ejeY_world = transform.up;
        Vector3 ejeZ_world = transform.forward;

        Debug.Log($"➡️ Eje X local (transform.right): {ejeX_world}");
        Debug.Log($"⬆️ Eje Y local (transform.up): {ejeY_world}");
        Debug.Log($"➡️ Eje Z local (transform.forward): {ejeZ_world}");

        // 3) Matriz local -> world
        Matrix4x4 M = transform.localToWorldMatrix;
        Debug.Log("📐 Matriz localToWorld (formato compacto):\n" + FormatMatrix(M));

        // 4) Ejemplo: convertir un punto local a mundial
        Vector3 puntoLocal = new Vector3(0.5f, 0.5f, 0.5f);
        Vector3 puntoWorld = M.MultiplyPoint(puntoLocal);
        Debug.Log($"🔁 Punto local {puntoLocal} → punto world {puntoWorld}");
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
