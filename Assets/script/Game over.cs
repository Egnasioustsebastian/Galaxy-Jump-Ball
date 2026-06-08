using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Gameover : MonoBehaviour
{
    public TextMeshProUGUI TimeText;
    public Image gameOverScreen;
    private void Start()
    {
        gameOverScreen.gameObject.SetActive(false);
    }
    public void ShowGameOverScreen(int time)
    {
        gameOverScreen.gameObject.SetActive(true);

        int minutes = time / 60;
        int seconds = time % 60;

        TimeText.text = "Time Played: " +
            string.Format("{0:00}:{1:00}", minutes, seconds);

        Time.timeScale = 0f;   // Pause game
    }
   
}