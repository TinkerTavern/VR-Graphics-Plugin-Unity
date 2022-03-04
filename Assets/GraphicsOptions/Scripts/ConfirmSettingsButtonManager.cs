using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;


public class ConfirmSettingsButtonManager : MonoBehaviour
{
    public string sceneToLoad;
    private UniversalRenderPipelineAsset urp;
    public void OnButtonPress() {
        SetFPSCap();
        SetResolutionScale();
        SceneManager.LoadScene (sceneName:sceneToLoad);

    }

    private void SetResolutionScale() {
        urp = (UniversalRenderPipelineAsset)GraphicsSettings.currentRenderPipeline;
        urp.renderScale = ResScaleManager.resScale;
    }

    private void SetFovScale() {

    }

    private void SetFPSCap() {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = FPSScaleManager.fpsCap;
    }
}
 