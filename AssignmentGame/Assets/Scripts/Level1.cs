using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    public KillCounter killCounter;
    private float killGoal = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (killCounter.killAmount == killGoal)
        {
            SceneManager.LoadScene("Passed");
        }
    }
}
