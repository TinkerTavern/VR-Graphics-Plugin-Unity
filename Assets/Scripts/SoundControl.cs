using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    void Start()
    {
        if (!SoundToggleManager.soundOn) {
            AudioListener.pause  = true;
            gameObject.GetComponent<Text>().text = "Sound OFF";
        }
    }
}
