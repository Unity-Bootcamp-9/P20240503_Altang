using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    private void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(0, 0, verticalInput) * 5 * Time.deltaTime);
        
        transform.Rotate(new Vector3(0, horizontalInput, 0) * 2);
    }
}
