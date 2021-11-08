using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EnemySpawn", 2.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void EnemySpawn()
    {
        Vector3 spawnPos = new Vector3(-200, 0, Random.Range(160, 320));
        Instantiate(enemy, spawnPos, enemy.transform.rotation * Quaternion.Euler(0, 85, 0));
    }
}
