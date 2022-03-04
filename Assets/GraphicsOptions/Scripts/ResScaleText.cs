using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResScaleText : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Text>().text = string.Format("Resolution: {0:F1}x\n", ResScaleManager.resScale);
    }
}
