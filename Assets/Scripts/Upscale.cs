using System.Collections;
using UnityEngine;

public class Upscale : MonoBehaviour
{
    public SecondaryButtonWatcher watcher;
    public DynamicResolutionTest dynamicResolution;
    public bool IsPressed = false; // used to display button state in the Unity Inspector window

    void Start()
    {
        watcher.secondaryButtonPress.AddListener(onsSecondaryButtonEvent);
    }

    public void onsSecondaryButtonEvent(bool pressed)
    {
        IsPressed = pressed;
        if (pressed)
            dynamicResolution.ChangeResolutionScale(false);
    }
}