using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   
    public Transform player;
    public Vector3 offset;

    // Use this for initialization
    void Start ()
    {
        player = GameObject.FindWithTag("Player").transform;
        // Distance at which the camera follow the player
        offset = transform.position - player.transform.position;
    }

    void LateUpdate ()
    {
        // Follow the player 
        if (player != null)
        {
            transform.position = player.transform.position + offset;
        }
       
    }
}
