using UnityEngine;

public class MoveThenRotate : MonoBehaviour
{
    void Start()
    {
        // Mover 2 metros en cada eje 
        transform.Translate(2f, 2f, 2f, Space.Self);

        // Luego rotar 30° alrededor del eje Y 
        transform.Rotate(0f, 30f, 0f, Space.Self);

        Debug.Log("MoveThenRotate -> Posición final: " + transform.position +
                  ", Rotación final: " + transform.rotation.eulerAngles);
    }
}
