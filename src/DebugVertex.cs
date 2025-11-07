using UnityEngine;
using System.Text;

public class DebugVertex : MonoBehaviour
{
    public GameObject[] vertex;
    Camera cam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //TODO: EL GREEN ESTA CORRECTO
        cam = GetComponent<Camera>();
        Vector4 pos = vertex[0].transform.localPosition;
        pos.w = 1;
        Vector4 greenClipCoords = cam.projectionMatrix * cam.worldToCameraMatrix * vertex[0].transform.parent.localToWorldMatrix * pos;
        Debug.Log("Clip coords de vertex verde: " + greenClipCoords);
        pos = vertex[1].transform.localPosition;
        pos.w = 1;
        Vector4 blueClipCoords = cam.projectionMatrix * cam.worldToCameraMatrix * vertex[1].transform.parent.localToWorldMatrix * pos;
        Debug.Log("Clip coords de vertex azul: " + blueClipCoords);
        pos = vertex[2].transform.localPosition;
        pos.w = 1;
        Vector4 redClipCoords = cam.projectionMatrix * cam.worldToCameraMatrix * vertex[2].transform.parent.localToWorldMatrix * pos;
        Debug.Log("Clip coords de vertex rojo: " + redClipCoords);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
