using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float sensitivity = 300f;

    private float yRotation = 0.0f;

    void Update()
    {

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        
        Vector3 direction = new Vector3(h, 0, v);
        
        transform.Translate(Time.deltaTime * direction);



        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        yRotation += mouseX;

        transform.localRotation = Quaternion.Euler(0f, yRotation, 0f);


    }
}
