using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCap : MonoBehaviour
{
    public int frameCap = 12;
    void Awake ()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = frameCap;
    }
}
