using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] enemy;

    [SerializeField] private float minTime;
    [SerializeField] private float maxTime;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", Random.Range(minTime, maxTime), Random.Range(minTime, maxTime));
    }

    private void SpawnEnemy()
    {
        Instantiate(enemy[Random.Range(0, enemy.Length)], transform.position, Quaternion.identity);
    }
    
}
