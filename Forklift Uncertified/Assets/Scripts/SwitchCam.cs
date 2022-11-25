using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour
{
    public Camera oneCam;
    public Camera twoCam;

    private bool nowMainCam = true;

    public void CamSwitch()
    {
        if (nowMainCam)
        {
            oneCam.depth = 0;
            twoCam.depth = 1;
            nowMainCam = false;
        } else if (!nowMainCam)
        {
            oneCam.depth = 1;
            twoCam.depth = 0;
            nowMainCam = true;
        }
    }
}
