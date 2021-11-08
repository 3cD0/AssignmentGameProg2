using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillCounter : MonoBehaviour
{
    public float killAmount;
    public TextMeshProUGUI killAmountText;
    private Timer timer;

    public float timeValue;
    public TextMeshProUGUI timerText;


    // Start is called before the first frame update
    void Start()
    {
        killAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);

        if (SceneManager.GetActiveScene().name == "Level1")
        {
            if (killAmount == 2 && timer.timeValue > 0)
            {
                SceneManager.LoadScene("Passed");
            }

            if (killAmount != 2 && timeValue == 0)
            {
                SceneManager.LoadScene("Failed");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level1")
        {
            if (killAmount == 4)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    public void IncreaseKillCount()
    {
        killAmount++;
        killAmountText.text = "Kills: " + killAmount.ToString();
    }

    private void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliseconds = timeToDisplay % 1 * 1000;

        timerText.text = string.Format("Time Remaining: {0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }
}
