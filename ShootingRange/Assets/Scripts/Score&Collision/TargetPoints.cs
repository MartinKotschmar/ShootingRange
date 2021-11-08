using UnityEngine;

public class TargetPoints : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("was shot");
        if (collision.gameObject.tag == "Bullet")
        {
            KeepScore.Score += 100;
            Debug.Log("Hit the ball");
            Destroy(this.gameObject);
        }
    }
}
