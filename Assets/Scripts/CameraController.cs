using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera mainCam;
    public Camera firstPersonCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            mainCam.gameObject.SetActive(!mainCam.gameObject.activeInHierarchy);
            firstPersonCam.gameObject.SetActive(!mainCam.gameObject.activeInHierarchy);
        }
    }
}
