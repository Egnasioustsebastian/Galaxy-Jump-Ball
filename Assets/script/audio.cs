using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class audio : MonoBehaviour
{
    
   
    public AudioSource SFXsource;

    public AudioClip background;
    public AudioClip death;
    public AudioClip jump;
    public AudioClip play;
    public AudioClip button;
    audio Audio;
  
    private void Awake()
    {
        Audio = GameObject.FindGameObjectWithTag("audio").GetComponent<audio>();
        
    }
    public void playSFX(AudioClip audioClip)
    {
        SFXsource.PlayOneShot(audioClip);
      
    }

    private void Start()
    {
       
        if (SceneManager.GetActiveScene().name == "level")
        {
           SFXsource.clip = play;
           SFXsource.Play();
        }
    }
  public void SetMusicVolume(float volumevalue)
    {
        
        SFXsource.volume = volumevalue;
        Debug.Log("volume playing");

    }

    public void MusicToggle(bool IsOn)
    {
        if (IsOn)
        {
            SFXsource.mute = false;
            Debug.Log("music on");
        }
        else
        {
            SFXsource.mute = true;
            Debug.Log("music off");
        }
    }

}
