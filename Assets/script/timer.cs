using UnityEngine;
using TMPro;
using System.Collections;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    float elapsedTime;
    private bool isRunning = true;
    void Start()
    {
        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        while (isRunning)
        {
            elapsedTime += 1f;

            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);

            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

            yield return new WaitForSeconds(1f);
           
        }
    }
    public int GetTime()
    {
        return Mathf.FloorToInt(elapsedTime);
    }
    public void StopTimer()
    {
        
        isRunning = false;
    }


}
