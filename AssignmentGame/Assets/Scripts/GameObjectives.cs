using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameObjectives : MonoBehaviour
{
    public float killAmount;
    public TextMeshProUGUI killAmountText;

    public float timeValue;
    public TextMeshProUGUI timerText;

    public GameObject enemy;
    public GameObject shooter;


    // Start is called before the first frame update
    void Start()
    {
        killAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Display Remaining time of a level
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);

        /*if (enemy.transform.position == shooter.transform.position)
        {
            SceneManager.LoadScene("Failed");
        }*/

        //Level 1
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            //Conditions for level 1
            if (killAmount == 20 && timeValue > 0)
            {
                SceneManager.LoadScene("Passed");
            }

            if (killAmount != 20 && timeValue == 0)
            {
                SceneManager.LoadScene("FailedLevel1");
            }

            /*if (enemy.transform.position == shooter.transform.position)
            {
                SceneManager.LoadScene("FailedLevel1");
            }*/
        }
        //Level 2
        else if (SceneManager.GetActiveScene().name == "Level2")
        {
            //Conditions for level 2
            if (killAmount == 50 && timeValue > 0)
            {
                SceneManager.LoadScene("GameOver");
            }

            if (killAmount != 50 && timeValue == 0)
            {
                SceneManager.LoadScene("FailedLevel2");
            }

            /*if (enemy.transform.position == shooter.transform.position)
            {
                SceneManager.LoadScene("FailedLevel2");
            }*/
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
