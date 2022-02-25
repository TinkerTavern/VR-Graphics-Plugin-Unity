using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResScaleSlider : MonoBehaviour
{
  private Text textSliderValue;

  void Start (){
    textSliderValue = GetComponent<Text>();
  }

  public void ShowSliderValue (float value) {
    textSliderValue.text = value.ToString("0.0");
  }
}
