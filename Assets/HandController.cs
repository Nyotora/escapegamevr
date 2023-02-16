using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using static UnityEditor.Progress;

public class HandController : MonoBehaviour
{

    public Camera camera;
    public XRController Lcontroller;
    public XRController Rcontroller;
    private InputDevice targetDevice;

    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice> ();
        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);
        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

        InputDevices.GetDevices(devices);
        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

        if (devices.Count > 0)
        {
            targetDevice = devices[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Rcontroller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue) && primary2DAxisValue.y > 0.3f)
        {
            Debug.Log("obj : " + transform.forward + "     cam : " + Vector3.Scale(camera.transform.forward, new Vector3(1, 0, 1)));
            transform.Translate(Vector3.Scale(camera.transform.forward, new Vector3(1, 0, 1)) * Time.deltaTime * 2, Space.World);
        }

        if (Rcontroller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue2) && primary2DAxisValue2.y < -0.3f)
            transform.Translate(Vector3.Scale(camera.transform.forward, new Vector3(-1, 0, -1)) * Time.deltaTime * 2, Space.World);

        if (Rcontroller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 rotationValue) && rotationValue.x != 0.0f)
            transform.RotateAround(transform.position, transform.up, Time.deltaTime * rotationValue.x * 90f);


    }
}
