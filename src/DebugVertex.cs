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
        Debug.Log("Clip coords de vertex verde: " + new Vector3((greenClipCoords.x / greenClipCoords.w + 1) / 2 * cam.pixelWidth, (greenClipCoords.y / greenClipCoords.w + 1) / 2 * cam.pixelHeight, greenClipCoords.z / greenClipCoords.w));
        Debug.Log(cam.WorldToScreenPoint(vertex[0].transform.position ));
        pos = vertex[1].transform.localPosition;
        pos.w = 1;
        Vector4 blueClipCoords = cam.projectionMatrix * cam.worldToCameraMatrix * vertex[1].transform.localToWorldMatrix * pos;
        Debug.Log("Clip coords de vertex azul: " + cam.WorldToScreenPoint(blueClipCoords));
        pos = vertex[2].transform.localPosition;
        pos.w = 1;
        Vector4 redClipCoords = cam.projectionMatrix * cam.worldToCameraMatrix * vertex[2].transform.localToWorldMatrix * pos;
        Debug.Log("Clip coords de vertex rojo: " + cam.WorldToScreenPoint(redClipCoords));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
