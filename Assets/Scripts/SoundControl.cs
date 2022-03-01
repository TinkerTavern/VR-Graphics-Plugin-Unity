using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public Text screenText;
    void Start()
    {
        if (!SoundToggleManager.soundOn) {
            AudioListener.pause  = true;
            screenText.text = "Sound OFF";
        }
    }
}
