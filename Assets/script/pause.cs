using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
  public GameObject pauseMenu;
    audio Audio;
    private void Awake()
    {
        Audio = GameObject.FindGameObjectWithTag("audio").GetComponent<audio>();
        
    }
    public void home()
    {
        Audio.playSFX(Audio.button);
        SceneManager.LoadScene("menu");
        Time.timeScale = 1f;
    }
  public void RestartGame()
    {
        Audio.playSFX(Audio.button);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ResumeGame()
    {
        Audio.playSFX(Audio.button);
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
    public void PauseGame()
    {
        Audio.playSFX(Audio.button);
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }
     public void QuitGame()
    {
        Application.Quit();
    }





}
