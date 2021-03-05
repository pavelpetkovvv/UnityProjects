using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float verticalSpeed = 2.0F;


    // Update is called once per frame
    void Update()
    {
        float v = verticalSpeed * Input.GetAxis("Mouse Y") * (-1);
        transform.Rotate(v, 0, 0);
    }
}