using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using Sigtrap.VrTunnellingPro;

public class FoVScaleText : MonoBehaviour
{
    private TunnellingMobile tunnellingMobile;

    void Start()
    {
        tunnellingMobile =  Camera.main.GetComponent<TunnellingMobile>();
        tunnellingMobile.effectCoverage = 1-FoVScaleManager.fovScale;
        gameObject.GetComponent<Text>().text = string.Format("FoV: {0:F1}x\n", FoVScaleManager.fovScale);
    }
}