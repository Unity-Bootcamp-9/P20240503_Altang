using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class ViewPointerTransformation : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> Cameras;

    private int runningCamera = 0;
    private int cameraCount;

    void Start()
    {
        foreach (var cam in Cameras)
        {
            cam.SetActive(false);
        }
        Cameras[runningCamera].SetActive(true);
        cameraCount = Cameras.Count;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Cameras[runningCamera].SetActive(false);

            ++runningCamera;
            runningCamera = runningCamera % cameraCount;

            Cameras[runningCamera].SetActive(true);
        }
    }
}
