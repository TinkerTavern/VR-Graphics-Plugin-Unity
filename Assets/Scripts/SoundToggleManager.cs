using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundToggleManager : MonoBehaviour
{
  public static bool soundOn = true;

  public void ToggleSound (bool value) {
    soundOn = value;
  }
}
