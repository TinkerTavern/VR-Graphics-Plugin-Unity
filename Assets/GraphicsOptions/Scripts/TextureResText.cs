using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextureResText : MonoBehaviour
{
    private Text m_Text;
    private string[] qualityLevles = {"Eighth", "Quarter", "Half", "Full"};

    private void Start() {
        m_Text = gameObject.GetComponent<Text>();
        m_Text.text = "Quality: " + qualityLevles[QualitySettings.GetQualityLevel()];
    }
}
