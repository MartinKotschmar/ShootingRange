using UnityEngine;

public class TPBack : MonoBehaviour
{
    private Vector3 teleportTargetLocation;
    public GameObject player;

    public void TeleportPlayerBack()
    {
        Debug.Log("Teleport Button clicked");
        player.transform.position = transform.position + new Vector3(25.37f, 2.5f, 22.609f);
        player.transform.Rotate(0f,180f,0f);

        //GameObject.Instantiate(player, teleportTargetLocation, Quaternion.identity);
    }
}
