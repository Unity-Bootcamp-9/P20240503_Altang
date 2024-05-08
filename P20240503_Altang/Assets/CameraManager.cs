using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CameraManager : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera[] cameras;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            RunCamera();
        }
    }


    void RunCamera()
    {
        switch(cameras[0].gameObject.activeSelf)
        {
            case true:
                cameras[0].gameObject.SetActive(false);
                cameras[1].gameObject.SetActive(true);
                break;
            default:
                cameras[0].gameObject.SetActive(true);
                cameras[1].gameObject.SetActive(false);
                break;
        }
    }
}
