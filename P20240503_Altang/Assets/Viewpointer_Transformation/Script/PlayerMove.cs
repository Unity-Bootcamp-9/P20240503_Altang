using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform mainCamera;
    private float yRotate, yRotateMove;
    public float rotateSpeed = 500.0f;

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Quaternion.Euler(transform.rotation.x, mainCamera.rotation.y * 100, transform.rotation.z);
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(h, 0, v);

        yRotateMove = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;

        yRotate = transform.eulerAngles.y + yRotateMove;

        transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotate, 0);

        transform.Translate(Time.deltaTime * direction);

    }
}
