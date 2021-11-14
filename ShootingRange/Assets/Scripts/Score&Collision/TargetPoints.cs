using System.Threading.Tasks;
using UnityEngine;

public class TargetPoints : MonoBehaviour
{
    public GameObject[] targets;
    public GameObject target;

    private Vector3 oldPosition;

    void Awake()
    {
        targets = GameObject.FindGameObjectsWithTag("Target");
    }
    private async void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            KeepScore.Score += 100;
            //wait for target to fold down
            await Task.Delay(300);
            //hide target
            this.gameObject.SetActive(false);

            //"respawn" after 2 seconds
            await Task.Delay(1200);
            //reset location after collision (reverse fold down)
            transform.rotation = Quaternion.Euler(-90, 0, 0);
            this.gameObject.SetActive(true);
        }

    }
}