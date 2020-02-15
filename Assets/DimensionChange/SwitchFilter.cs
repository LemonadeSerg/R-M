using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchFilter : MonoBehaviour
{

    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ToggleCull("BLUE-World");
        }
        if (Input.GetButtonDown("Fire2"))
        {
            ToggleCull("RED-World");
        }
    }


    private void ToggleCull(string layer)
    {
        camera.cullingMask ^= 1 << LayerMask.NameToLayer(layer);
    }
     

}
