using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ConfirmSettings : MonoBehaviour
{
    public void OnButtonPress() {
        DynamicResolution.resolutionScale = ResScaleManager.resScale;
        FPSCap.fpsCapIndex = FPSScaleManager.fpsCap;
        SceneManager.LoadScene (sceneName:"GameScene");

    }
}
