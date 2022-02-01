using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;

[System.Serializable]
public class GripButtonEvent : UnityEvent<bool> { }

public class GripButtonWatcher : MonoBehaviour
{
    public GripButtonEvent gripButtonPress;

    private bool lastButtonState = false;
    private List<InputDevice> devicesWithGripButton;

    private void Awake()
    {
        if (gripButtonPress == null)
        {
            gripButtonPress = new GripButtonEvent();
        }

        devicesWithGripButton = new List<InputDevice>();
    }

    void OnEnable()
    {
        List<InputDevice> allDevices = new List<InputDevice>();
        InputDevices.GetDevices(allDevices);
        foreach(InputDevice device in allDevices)
            InputDevices_deviceConnected(device);

        InputDevices.deviceConnected += InputDevices_deviceConnected;
        InputDevices.deviceDisconnected += InputDevices_deviceDisconnected;
    }

    private void OnDisable()
    {
        InputDevices.deviceConnected -= InputDevices_deviceConnected;
        InputDevices.deviceDisconnected -= InputDevices_deviceDisconnected;
        devicesWithGripButton.Clear();
    }

    private void InputDevices_deviceConnected(InputDevice device)
    {
        bool discardedValue;
        if (device.TryGetFeatureValue(CommonUsages.gripButton, out discardedValue))
        {
            devicesWithGripButton.Add(device); // Add any devices that have a grip button.
        }
    }

    private void InputDevices_deviceDisconnected(InputDevice device)
    {
        if (devicesWithGripButton.Contains(device))
            devicesWithGripButton.Remove(device);
    }

    void Update()
    {
        bool tempState = false;
        foreach (var device in devicesWithGripButton)
        {
            bool gripButtonState = false;
            tempState = device.TryGetFeatureValue(CommonUsages.gripButton, out gripButtonState) // did get a value
                        && gripButtonState // the value we got
                        || tempState; // cumulative result from other controllers
        }

        if (tempState != lastButtonState) // Button state changed since last frame
        {
            gripButtonPress.Invoke(tempState);
            lastButtonState = tempState;
        }
    }
}