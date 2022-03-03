using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSScaleManager : MonoBehaviour
{
    public Text textSliderValue;
    public int[] frameCaps = {30,45,60,90,120,144};
    public static int fpsCap;

    void Start (){
        textSliderValue = GetComponent<Text>();
        fpsCap = 90;
    }

    public void ShowSliderValue (float value) {
        fpsCap = frameCaps[(int)value];
        textSliderValue.text = fpsCap.ToString();
    }
}
