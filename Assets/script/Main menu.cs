using UnityEngine;
using UnityEngine.SceneManagement;


public class Mainmenu : MonoBehaviour
{
    audio Audio;

  private void Awake()
    {
        Audio = GameObject.FindGameObjectWithTag("audio").GetComponent<audio>();
        Audio.playSFX(Audio.background);
       if (PlayerPrefs.GetInt("audio") == 0)
        {
            Audio.SFXsource.mute = true;
        }
        else
        {
            Audio.SFXsource.mute = false;
        }
    }

    public void PlayGame()
    {
        Audio.playSFX(Audio.button);
        Debug.Log("play");
        SceneManager.LoadScene("level");

    }

    public void settings()
    {
        Audio.playSFX(Audio.button);
        Debug.Log("settings");
       
    }   

    public  void QuitGame()
    {
        Audio.playSFX(Audio.button);
        Debug.Log("quit");
        Application.Quit();
    }

    

}
