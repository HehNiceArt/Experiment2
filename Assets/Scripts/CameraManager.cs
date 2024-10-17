using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    public CinemachineVirtualCamera VirtualCamera1, VirtualCamera2;
    private bool isCamera1Active = true;  // Tracks the active camera
    private void Start()
    {
        VirtualCamera1.Priority = 10;
        VirtualCamera2.Priority = 5;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            SwitchCameras();
        }
    }

    void SwitchCameras()
    {
        if (isCamera1Active)
        {
            VirtualCamera1.Priority = 5;
            VirtualCamera2.Priority = 10;
        }
        else
        {
            VirtualCamera1.Priority = 10;
            VirtualCamera2.Priority = 5;
        }

        isCamera1Active = !isCamera1Active; 
    }

}
