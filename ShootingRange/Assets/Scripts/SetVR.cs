using UnityEngine;

public class SetVR : MonoBehaviour
{
    public GameObject VRRig;
    public GameObject WebGLRig;
    private bool isOnVRDevice = true;

    private void Awake()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            isOnVRDevice = true;
        }

        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            isOnVRDevice = true;
        }

        VRRig.SetActive(isOnVRDevice);
        WebGLRig.SetActive(!isOnVRDevice);
    }
}
