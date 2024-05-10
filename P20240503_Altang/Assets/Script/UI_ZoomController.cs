using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ZoomController : MonoBehaviour
{

    private void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            gameObject.SetActive(true);    
        }

        if (Input.GetMouseButtonUp(1))
        {
            gameObject.SetActive(false);
        }
    }
}
