using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMove : MonoBehaviour
{
    private float xRotate, xRotateMove;
    public float rotateSpeed = 500.0f;


    void Update()
    {

        //xRotateMove = -Input.GetAxis("Mouse Y") * Time.deltaTime * rotateSpeed;

        float mouseY = -Input.GetAxis("Mouse Y");
        float rotationAmount = mouseY * Time.deltaTime * rotateSpeed;
        float newRotation = transform.eulerAngles.x + rotationAmount;

        newRotation = Mathf.Clamp(newRotation, -70f, 70f);
        
        if(newRotation < 0)
        {
            newRotation += 360;
        }

         xRotate = transform.eulerAngles.x + xRotateMove;
         xRotate = Mathf.Clamp(xRotate, -300f, 300f);
        //transform.rotation = Quaternion.Euler(newRotation, transform.eulerAngles.y, 0f);
        transform.localRotation = Quaternion.Euler(newRotation, 360, 360);
        
    }

}
