using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartCurrentLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level1" && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Level1");
        }
        else if (SceneManager.GetActiveScene().name == "Level2" && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
