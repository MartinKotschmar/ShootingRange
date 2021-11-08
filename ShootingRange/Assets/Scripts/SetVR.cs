using UnityEngine;

public class SetVR : MonoBehaviour
{
    public GameObject VRRig;
    public GameObject WebGLRig;
    private bool isOnVRDevice = false;

    private void Awake()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            isOnVRDevice = true;
        }

        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            isOnVRDevice = false;
        }

        VRRig.SetActive(isOnVRDevice);
        WebGLRig.SetActive(!isOnVRDevice);
    }
}
