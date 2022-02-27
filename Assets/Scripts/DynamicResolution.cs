using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class DynamicResolution : MonoBehaviour
{
    public Text screenText;
    UniversalRenderPipelineAsset urp;
    public static float resolutionScale = 1.0f;

    void Start()
    {
        urp = (UniversalRenderPipelineAsset)GraphicsSettings.currentRenderPipeline;
        urp.renderScale = resolutionScale;
        screenText.text = string.Format("Scale: {0:F1}\n", urp.renderScale);
    }
}
