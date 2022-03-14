using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureResolutionManager : MonoBehaviour
{
    void Start() {
        QualitySettings.SetQualityLevel(4, true);
    }

    public void OnValueChanged(int level) {
        QualitySettings.SetQualityLevel(3-level, true);
    }
}
