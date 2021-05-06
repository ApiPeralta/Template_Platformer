using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instantiator_ARRIBA : MonoBehaviour
{
    public GameObject enemy;
    public GameObject instantiatePos;
    public float respawningTimer;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemies();
    }
    private void SpawnEnemies()
    {
        respawningTimer -= Time.deltaTime;
        if (respawningTimer <= 0)
        {
            Instantiate(enemy, instantiatePos.transform);
            respawningTimer = UnityEngine.Random.Range(3,5);
        }
    }
}
