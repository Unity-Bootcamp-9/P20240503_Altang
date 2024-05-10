using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    CinemachineFollowZoom zoom;
    public GameObject panel;
    private Vector2 vec = new Vector2(30f, 60f);

    void Start()
    {
        zoom = GetComponent<CinemachineFollowZoom>();
        panel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            zoom.m_MaxFOV = vec.x;
            panel.SetActive(true);
        }

        if (Input.GetMouseButtonUp(1))
        {
            zoom.m_MaxFOV = vec.y;
            panel.SetActive(false);
        }
    }
}
