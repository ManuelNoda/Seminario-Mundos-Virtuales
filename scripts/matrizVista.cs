using UnityEngine;
using System.Text;

public class ViewMatrixExample : MonoBehaviour
{
    void Start()
    {
        // Posición y rotación de la cámara
        Vector3 camPos = transform.position;
        Quaternion camRot = transform.rotation;

        // Crear matriz de rotación y traslación
        Matrix4x4 rotMatrix = Matrix4x4.Rotate(camRot);
        Matrix4x4 transMatrix = Matrix4x4.Translate(-camPos);

        // Matriz de vista (inversa de la transformación de la cámara)
        Matrix4x4 viewMatrix = rotMatrix.transpose * transMatrix;

        // Mostrar la matriz con formato
        Debug.Log("Matriz de Vista:" + FormatMatrix(viewMatrix));
    }

    // Función para formatear matrices en estilo caja
    string FormatMatrix(Matrix4x4 m)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("\n┌───────────────────────────┐");

        for (int i = 0; i < 4; i++)
        {
            sb.Append("│ ");
            for (int j = 0; j < 4; j++)
            {
                sb.Append($"{m[i, j],8:F4} ");
            }
            sb.AppendLine("│");
        }

        sb.AppendLine("└───────────────────────────┘");
        return sb.ToString();
    }
}
