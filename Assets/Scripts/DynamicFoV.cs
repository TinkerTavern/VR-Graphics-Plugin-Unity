using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class DynamicFoV : MonoBehaviour
{
    public Text screenText;
    public static float fovScale = 1.0f;

    void Start()
    {
        Sigtrap.VrTunnellingPro.TunnellingBase.effectCoverage = 1-fovScale;
        screenText.text = string.Format("Scale: {0:F1}\n", fovScale);
    }
}
