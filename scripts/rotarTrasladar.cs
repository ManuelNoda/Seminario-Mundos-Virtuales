using UnityEngine;

public class RotateThenMove : MonoBehaviour
{
    void Start()
    {
        // Rotar 30° alrededor del eje Y 
        transform.Rotate(0f, 30f, 0f, Space.Self);

        // Luego mover 2 metros en cada eje (espacio global)
        transform.Translate(2f, 2f, 2f, Space.Self);

        Debug.Log("RotateThenMove -> Posición final: " + transform.position +
                  ", Rotación final: " + transform.rotation.eulerAngles);
    }
}
