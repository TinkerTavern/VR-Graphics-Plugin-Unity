using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCap : MonoBehaviour
{
    public int[] frameCaps = {30,45,60,72,90,120,144};
    public static int fpsCapIndex = 0;
    void Start ()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = frameCaps[fpsCapIndex];
    }

    public void ChangeCap(bool isUp) {
        if (isUp) {
            if (fpsCapIndex
     < frameCaps.Length-1) {
                Application.targetFrameRate = frameCaps[++fpsCapIndex
        ];
            }
        }
        else {
            if (fpsCapIndex
     > 0) {
                Application.targetFrameRate = frameCaps[--fpsCapIndex
        ];
            }
        }
    }
}
