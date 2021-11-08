using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public GameObjectives gameObjective;
    // Start is called before the first frame update
    void Start()
    {
        gameObjective = GameObject.Find("Canvas").GetComponent<GameObjectives>();

        if (gameObjective == null)
        {
            Debug.LogError("KillCounter is null");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        gameObjective.IncreaseKillCount();
    }
}
