using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ResScaleManager : MonoBehaviour
{
  private Text textSliderValue;
  public static float resScale;

  void Start (){
    textSliderValue = GetComponent<Text>();
    resScale = 1.0f;
  }

  public void ShowSliderValue (float value) {
    resScale = (float)Math.Round((double)value,1);
    textSliderValue.text = resScale.ToString("0.0");
  }
}
