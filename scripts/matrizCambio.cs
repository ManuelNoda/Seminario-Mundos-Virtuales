using UnityEngine;
using System.Text;

public class ObjectRotationAndWorldMatrix : MonoBehaviour
{
    void Start()
    {
        //  Aplicar una rotación de 45° en Y (local)
        Quaternion rotationY = Quaternion.Euler(0f, 45f, 0f);
        transform.localRotation = transform.localRotation * rotationY;

        //  Obtener la matriz de cambio al sistema de referencia mundial
        Matrix4x4 worldMatrix = transform.localToWorldMatrix;

        // 3 Mostrarla en consola usando el FormatMatrix
        Debug.Log("Matriz de cambio al sistema de referencia mundial:" + FormatMatrix(worldMatrix));
    }

    // Función para formatear matrices.
    string FormatMatrix(Matrix4x4 m)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("\n.............................");

        for (int i = 0; i < 4; i++)
        {
            sb.Append(". ");
            for (int j = 0; j < 4; j++)
            {
                sb.Append($"{m[i, j],8:F4} ");
            }
            sb.AppendLine(".");
        }

        sb.AppendLine("................................");
        return sb.ToString();
    }
}
