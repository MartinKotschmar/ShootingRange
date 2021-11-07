using UnityEngine;

public class Gun : MonoBehaviour
{
    public float speed = 4000;
    public GameObject bullet;
    public Transform barrel;
    public AudioSource audioSource;
    public AudioClip audioClip;

    public void Fire()
    {
        GameObject spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
        //bullet isn't moving forward, check if it exists
        spawnedBullet.GetComponent<Rigidbody>().AddForce(speed * barrel.forward);
        Debug.Log(spawnedBullet.GetComponent<Rigidbody>().velocity);
        audioSource.PlayOneShot(audioClip);
        Destroy(spawnedBullet, 2);
    }
}
