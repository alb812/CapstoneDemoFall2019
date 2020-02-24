using Cinemachine.Utility;
using Cinemachine;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CinemachineFixScript : MonoBehaviour
{
    public CinemachineVirtualCamera cameraList;
    public CinemachineBrain mainCameraBrain;

    private ICinemachineCamera currentCamera;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            currentCamera = mainCameraBrain.ActiveVirtualCamera;
            if (currentCamera != cameraList)
            {
                currentCamera.VirtualCameraGameObject.SetActive(false);
                cameraList.VirtualCameraGameObject.SetActive(true);
            }
        }
    }

}