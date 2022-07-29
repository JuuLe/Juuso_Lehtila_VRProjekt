using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using CommonUsages = UnityEngine.XR.CommonUsages;
using InputDevice = UnityEngine.XR.InputDevice;

[System.Serializable]
public class ResetButton : UnityEvent<bool> { }

public class FullScore : MonoBehaviour
{
    public ResetButton knapptryck;

    [HideInInspector] public static int throws;
    [HideInInspector] public static int fullscore;
    [SerializeField] public static int score;

    private bool lastButtonState = false;
    private List<InputDevice> devicesWithPrimaryButton;



    private void Awake()
    {
        if (knapptryck == null)
        {
            knapptryck = new ResetButton();
        }

        devicesWithPrimaryButton = new List<InputDevice>();
    }

    void OnEnable()
    {
        List<InputDevice> allDevices = new List<InputDevice>();
        InputDevices.GetDevices(allDevices);
        foreach (InputDevice device in allDevices)
            InputDevices_deviceConnected(device);

        InputDevices.deviceConnected += InputDevices_deviceConnected;
        InputDevices.deviceDisconnected += InputDevices_deviceDisconnected;
    }

    private void OnDisable()
    {
        InputDevices.deviceConnected -= InputDevices_deviceConnected;
        InputDevices.deviceDisconnected -= InputDevices_deviceDisconnected;
        devicesWithPrimaryButton.Clear();
    }

    private void InputDevices_deviceConnected(InputDevice device)
    {
        bool discardedValue;
        if (device.TryGetFeatureValue(CommonUsages.primaryButton, out discardedValue))
        {
            devicesWithPrimaryButton.Add(device); // Add any devices that have a primary button.
        }
    }

    private void InputDevices_deviceDisconnected(InputDevice device)
    {
        if (devicesWithPrimaryButton.Contains(device))
            devicesWithPrimaryButton.Remove(device);
    }

    void Update()
    {
        bool tempState = false;
        foreach (var device in devicesWithPrimaryButton)
        {
            bool primaryButtonState = false;
            tempState = device.TryGetFeatureValue(CommonUsages. primaryButton, out primaryButtonState) // did get a value
                        && primaryButtonState // the value we got
                        || tempState; // cumulative result from other controllers
        }

        if (tempState =! lastButtonState) 
            // && tempState == true) // Button state changed since last frame (lade till att den inte ska aktiveras när man släpper knappen)
        {
            knapptryck.Invoke(tempState);
            lastButtonState = tempState;
            fullscore = fullscore + score;            
            throws++;
            score = 0;

            Debug.Log("score " + score);
            Debug.Log("fullscore " + fullscore);
            Debug.Log("throws " + throws);
            Debug.Log("tempState " + tempState);
            Debug.Log("lastButtonState " + lastButtonState);
        }

            //tempState = false;
            Debug.Log("tempState " + tempState);


    }

    // private void Start()
    // {
    //    fullscore = 0;
    //  InputDevices.GetDevices();
    //}
    //private void OnEnable()
  //  void update()
    //{
      //  if (device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.primaryButton,out knapptryck))
        //{ 

      //  }
    //}
}
