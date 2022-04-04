using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FoVScaleManager : MonoBehaviour
{
  private Text textSliderValue;
  public static float fovScale = 1.0f;
  public ShapeScales[] shapeScales;
  public static List<ShapeScales> shapeScalesList;

  void Start (){
    textSliderValue = GetComponent<Text>();
    ShowSliderValue(1.0f);
    shapeScalesList = new List<ShapeScales>(shapeScales);
  }

  public void ShowSliderValue (float value) {
    fovScale = (float)Math.Round((double)value,1);
    textSliderValue.text = fovScale.ToString("0.0");
  }

  [Serializable]
  public struct ShapeScales {
    public float scaleStart;
    public string meshName;
  }
}
