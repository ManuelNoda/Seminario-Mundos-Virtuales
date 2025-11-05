using UnityEngine;

public class MoveRQuaternin : MonoBehaviour
{
    void Start()
    {
        // Primero mover 2 metros en cada eje local (antes de rotar)
        transform.Translate(2f, 2f, 2f, Space.Self);

        // Crear una rotación local de 30° alrededor del eje Y
        Quaternion localRotationY = Quaternion.Euler(0f, 30f, 0f);

        // Aplicar la rotación al transform en espacio local
        transform.localRotation = transform.localRotation * localRotationY;

        Debug.Log("MoveThenRotate (Local) -> Posición final: " + transform.position +
                  ", Rotación final: " + transform.localRotation.eulerAngles);
    }
}
