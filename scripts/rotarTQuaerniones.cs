using UnityEngine;

public class RotateTQuaternion : MonoBehaviour
{
    void Start()
    {
        // Crear una rotación local de 30° alrededor del eje Y
        Quaternion localRotationY = Quaternion.Euler(0f, 30f, 0f);

        // Aplicar la rotación al transform en espacio local
        transform.localRotation = transform.localRotation * localRotationY;

        // Luego mover 2 metros en cada eje, según los ejes locales del objeto
        transform.Translate(2f, 2f, 2f, Space.Self);

        Debug.Log("RotateThenMove (Local) -> Posición final: " + transform.position +
                  ", Rotación final: " + transform.localRotation.eulerAngles);
    }
}

