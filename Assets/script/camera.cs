
using UnityEngine;


public class camera : MonoBehaviour


{
    public Transform player;
    public Vector3 offset;
    void LateUpdate()
    {
       
        if (player != null)
        {
           // transform.position = player.position + offset;
           transform.position = new Vector3 (player.position.x + offset .x, player.position .y + offset.y, transform.position. z);
            
        }
    }
}
