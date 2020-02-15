using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    // Start is called before the first frame update
    public MeshRenderer side1, side2;

    public GameObject otherPortal;
    public GameObject player;
    RenderTexture renderTexture;
    public Camera cam;
    public Transform playerCamera;
    public GameObject pTracker;
    void Start()
    {
        renderTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cam.targetTexture = renderTexture;
        side1.material.mainTexture = renderTexture;
        side2.material.mainTexture = renderTexture;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        pTracker.transform.position = playerCamera.transform.position;
        pTracker.transform.rotation = playerCamera.transform.rotation;
        cam.transform.localPosition = pTracker.transform.localPosition;
        cam.transform.localRotation = pTracker.transform.localRotation;
    }
}
