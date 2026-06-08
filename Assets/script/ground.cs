using UnityEngine;

public class ground : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float resetPositionX = -10f;   // When it reaches here
    public float startPositionX = 10f;    // Reset to here

    void Update()
    {
        // Move left continuously
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        // Reset position when it goes too far left
        if (transform.position.x <= resetPositionX)
        {
            transform.position = new Vector3(startPositionX, transform.position.y, transform.position.z);
        }
    }
}
