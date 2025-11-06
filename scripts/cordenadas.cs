using UnityEngine;

public class VertexTransformation : MonoBehaviour
{
    public Vector3 localVertex = new Vector3(0.5f, 0.5f, 0.5f); // Vértice en el espacio local
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;

        // 1. Local -> World
        Vector3 worldVertex = transform.TransformPoint(localVertex);
        Debug.Log("1. Local -> World: " + worldVertex);

        // 2. World -> View (Matriz de vista)
        Matrix4x4 viewMatrix = mainCamera.worldToCameraMatrix;
        Vector4 viewVertex = viewMatrix * new Vector4(worldVertex.x, worldVertex.y, worldVertex.z, 1);
        Debug.Log("2. World -> View: " + viewVertex);

        // 3. View -> Clip (Matriz de proyección perspectiva)
        Matrix4x4 projectionMatrix = mainCamera.projectionMatrix;
        Vector4 clipVertex = projectionMatrix * viewVertex;
        Debug.Log("3. View -> Clip: " + clipVertex);

        // 4. Clip -> NDC (Normalización dividiendo por W)
        Vector3 ndcVertex = new Vector3(clipVertex.x / clipVertex.w, clipVertex.y / clipVertex.w, clipVertex.z / clipVertex.w);
        Debug.Log("4. Clip -> NDC: " + ndcVertex);

        // 5. NDC -> Viewport (Coordenadas de la pantalla)
        Vector3 viewportVertex = new Vector3(
            (ndcVertex.x + 1) * 0.5f * Screen.width,
            (ndcVertex.y + 1) * 0.5f * Screen.height,
            ndcVertex.z);
        Debug.Log("5. NDC -> Viewport: " + viewportVertex);
    }
}
