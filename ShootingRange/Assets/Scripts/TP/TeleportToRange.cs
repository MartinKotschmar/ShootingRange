using UnityEngine;

public class TeleportToRange : MonoBehaviour
{
    private Vector3 teleportTargetLocation;
    public GameObject player;

    public void TeleportPlayer()
    {
        Vector3 teleportTargetLocation = new Vector3(16, 2.5f, -5);
        player.transform.position = teleportTargetLocation;

        //GameObject.Instantiate(player, teleportTargetLocation, Quaternion.identity);
    }
}
