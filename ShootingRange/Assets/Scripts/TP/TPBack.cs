using UnityEngine;

public class TPBack : MonoBehaviour
{
    private Vector3 teleportTargetLocation;
    public GameObject player;

    public void TeleportPlayerBack()
    {
        Debug.Log("Teleport Button clicked");
        Vector3 teleportTargetLocation = new Vector3(25.37f, 2.5f, 22.609f);
        player.transform.position = teleportTargetLocation;

        //GameObject.Instantiate(player, teleportTargetLocation, Quaternion.identity);
    }
}
