using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCap : MonoBehaviour
{
    public int[] frameCaps = {30,45,60,72,90,120,144};
    private int index = 0;
    void Awake ()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = frameCaps[index];
    }

    public void ChangeCap(bool isUp) {
        if (isUp) {
            if (index < frameCaps.Length-1) {
                Application.targetFrameRate = frameCaps[++index];
            }
        }
        else {
            if (index > 0) {
                Application.targetFrameRate = frameCaps[--index];
            }
        }
    }
}
