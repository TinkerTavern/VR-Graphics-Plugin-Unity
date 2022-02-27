using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class DynamicResolutionTest : MonoBehaviour
{
    public Text screenText;

    public float maxResolutionScale = 2.0f;
    public float minResolutionScale = 0.5f;
    public float scaleIncrement = 0.1f;
    UniversalRenderPipelineAsset urp;
    public static float resolutionScale = 1.0f;


    // Use this for initialization
    void Start()
    {
        urp = (UniversalRenderPipelineAsset)GraphicsSettings.currentRenderPipeline;
        urp.renderScale = resolutionScale;
        screenText.text = string.Format("Scale: {0:F3}\n", urp.renderScale);
    }

    public void ChangeResolutionScale(bool isUp) {
        if (isUp)
            urp.renderScale -= scaleIncrement;
        else
            urp.renderScale += scaleIncrement;
        screenText.text = string.Format("Scale: {0:F3}\n", urp.renderScale);
    }
}
