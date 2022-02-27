using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSScaleManager : MonoBehaviour
{
    public Text textSliderValue;
    public int[] frameCaps = {30,45,60,90,120,144};
    public static int fpsCap = 3;

    void Start (){
        textSliderValue = GetComponent<Text>();
    }

    public void ShowSliderValue (float value) {
        fpsCap = (int)value;
        textSliderValue.text = frameCaps[fpsCap].ToString();
    }
}
