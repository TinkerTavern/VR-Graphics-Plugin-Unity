using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ConfirmSettings : MonoBehaviour
{
    public string sceneToLoad;
    public void OnButtonPress() {
        DynamicResolution.resolutionScale = ResScaleManager.resScale;
        FPSCap.fpsCapIndex = FPSScaleManager.fpsCap;
        DynamicFoV.fovScale = FoVScaleManager.fovScale;
        SceneManager.LoadScene (sceneName:sceneToLoad);

    }
}
 