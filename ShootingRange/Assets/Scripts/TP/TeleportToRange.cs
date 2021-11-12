using UnityEngine;

public class TeleportToRange : MonoBehaviour
{
    private Vector3 teleportTargetLocation;
    public GameObject player;

    public void TeleportPlayer()
    {
        Vector3 teleportTargetLocation = new Vector3(22.5f, 2.5f, -6.2f);
        Vector3 teleportTargetRotation = new Vector3(0, 180, 0);
        player.transform.position = teleportTargetLocation;
        player.transform.Rotate(teleportTargetRotation, Space.World);

        //GameObject.Instantiate(player, teleportTargetLocation, Quaternion.identity);
    }
}
