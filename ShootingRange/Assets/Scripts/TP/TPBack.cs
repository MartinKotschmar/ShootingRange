using UnityEngine;

public class TPBack : MonoBehaviour
{
    public GameObject player;

    private Vector3 teleportTargetLocation;

    public void TeleportPlayerBack()
    {
        Vector3 teleportTargetLocation = new Vector3(26f, 2.5f, 23.65f);
        Vector3 teleportTargetRotation = new Vector3(0, -180, 0);
        player.transform.position = teleportTargetLocation;
        player.transform.Rotate(teleportTargetRotation, Space.World);
    }
}
