using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ResScaleManager : MonoBehaviour
{
  private Text textSliderValue;
  public static float resScale = 1.0f;

  void Start (){
    textSliderValue = GetComponent<Text>();
  }

  public void ShowSliderValue (float value) {
    resScale = (float)Math.Round((double)value,1);
    textSliderValue.text = resScale.ToString("0.0");
  }
}
