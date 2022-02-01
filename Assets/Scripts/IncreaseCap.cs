using System.Collections;
using UnityEngine;

public class IncreaseCap : MonoBehaviour
{
    public TriggerButtonWatcher watcher;
    public FPSCap fPSCap;
    public bool IsPressed = false; // used to display button state in the Unity Inspector window

    void Start()
    {
        watcher.triggerButtonPress.AddListener(onTriggerButtonEvent);
    }

    public void onTriggerButtonEvent(bool pressed)
    {
        IsPressed = pressed;
        if (pressed)
            fPSCap.ChangeCap(true);
    }
}