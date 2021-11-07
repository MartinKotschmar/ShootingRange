using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject[] spawnLocations;
    public GameObject player;

    private Vector3 respawnLocation;

    void Awake()
    {
        spawnLocations = GameObject.FindGameObjectsWithTag("SpawnPoint");

    }
    void Start()
    {
        //player = (GameObject)Resources.Load("Player", typeof(GameObject));
        respawnLocation = player.transform.position;
        SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        int spawn = Random.Range(0, spawnLocations.Length);
        GameObject.Instantiate(player, spawnLocations[spawn].transform.position, Quaternion.identity);

        //testing
        //GameObject.Instantiate(player, new Vector3(26, 2.5f, 24), Quaternion.identity);
    }

    public void TeleportPlayer()
    {
        Debug.Log("teleBtn click");
        Vector3 teleportTargetLocation = new Vector3(16, 2.5f, -5);
        player.transform.position = teleportTargetLocation;

        GameObject.Instantiate(player, teleportTargetLocation, Quaternion.identity);
    }
}
