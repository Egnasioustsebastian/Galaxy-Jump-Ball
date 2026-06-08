using UnityEngine;


public class player : MonoBehaviour
{
    audio Audio;
    Rigidbody2D rb;
    
    

   
    public float jumpForce = 10f;
    public bool grounded;

    private void Awake()
    {
        Audio = GameObject.FindGameObjectWithTag("audio").GetComponent<audio>();
}
        void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
       
    }

    void Update()
    {
        
        // Jump
        
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
           Audio.playSFX(Audio.jump);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            grounded = false;
        }
     
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }

}
