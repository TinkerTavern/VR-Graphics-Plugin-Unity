using System.Collections;
using UnityEngine;

public class DecreaseCap : MonoBehaviour
{
    public GripButtonWatcher watcher;
    public FPSCap fPSCap;
    public bool IsPressed = false; // used to display button state in the Unity Inspector window

    void Start()
    {
        watcher.gripButtonPress.AddListener(onGripButtonEvent);
    }

    public void onGripButtonEvent(bool pressed)
    {
        IsPressed = pressed;
        if (pressed)
            fPSCap.ChangeCap(false);
    }
}