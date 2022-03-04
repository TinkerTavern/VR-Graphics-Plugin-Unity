using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SoundToggleText : MonoBehaviour
{
    void Start()
    {
        if (AudioListener.pause)
            gameObject.GetComponent<Text>().text = "Sound OFF";
    }
}
