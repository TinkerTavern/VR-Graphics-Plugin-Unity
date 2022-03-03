using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using Sigtrap.VrTunnellingPro;

public class DynamicFoV : MonoBehaviour
{
    public Text screenText;
    private TunnellingMobile tunnellingMobile;
    public static float fovScale = 1.0f;

    void Start()
    {
        tunnellingMobile =  Camera.main.GetComponent<TunnellingMobile>();
        tunnellingMobile.effectCoverage = 1-fovScale;
        screenText.text = string.Format("Scale: {0:F1}\n", fovScale);
    }
}