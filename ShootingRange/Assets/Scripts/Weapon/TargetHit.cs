using UnityEngine;

public class TargetHit : MonoBehaviour
{

    public GameObject target;
    // Start is called before the first frame update

    void Start () 
    {
        TargetRotate();
    }
    void TargetRotate ()
    {
        target.transform.Rotate(-90f, 0f, 0f);

        Invoke("ResetTarget", 5);
    }

    void ResetTarget ()
    {
        target.transform.Rotate(90f,0f,0f);
    }
}
