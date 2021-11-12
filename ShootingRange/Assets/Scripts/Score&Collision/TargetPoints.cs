using UnityEngine;
using System.Threading;

public class TargetPoints : MonoBehaviour
{

    public GameObject[] targets;

    public GameObject target;

    private Vector3 oldPosition;

    void Awake () 
    {
        targets = GameObject.FindGameObjectsWithTag("Target");
    }
    private void OnCollisionEnter(Collision collision)
    {

        int spawn = Random.Range(0, targets.Length);

        Debug.Log("was shot");
        if (collision.gameObject.tag == "Bullet")
        {
            KeepScore.Score += 100;
            Debug.Log("Hit the ball");
            this.gameObject.transform.position = oldPosition;
            Destroy(this.gameObject);
            Thread.Sleep(5);
            GameObject.Instantiate(target, oldPosition, Quaternion.identity);
        }
    
    }
}
