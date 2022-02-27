using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResScaleManager : MonoBehaviour
{
  private Text textSliderValue;
  public static float resScale;

  void Start (){
    textSliderValue = GetComponent<Text>();
  }

  public void ShowSliderValue (float value) {
    resScale = value;
    textSliderValue.text = resScale.ToString("0.0");
  }
}
