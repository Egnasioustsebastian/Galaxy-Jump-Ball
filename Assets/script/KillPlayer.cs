using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    audio Audio;
    public Gameover gameover;
    public Timer timer;   // ADD THIS

    private void Awake()
    {
        Audio = GameObject.FindGameObjectWithTag("audio").GetComponent<audio>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            timer.StopTimer();   // Stop timer

            int totalTime = timer.GetTime();  // Get total time

            Destroy(other.gameObject);
            Audio.playSFX(Audio.death);
            gameover.ShowGameOverScreen(totalTime);  // Send time
        }
    }
}