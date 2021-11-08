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
        spawnedBullet.GetComponent<Rigidbody>().AddForce(speed * barrel.forward);

        //audioSource.PlayOneShot(audioClip);
        Destroy(spawnedBullet, 60);
    }
}
