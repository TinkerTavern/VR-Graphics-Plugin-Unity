using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundToggleManager : MonoBehaviour
{
  public void Start() {
    ToggleSound(true);
  }
  public void ToggleSound (bool value) {
    AudioListener.pause = !value;
  }
}
