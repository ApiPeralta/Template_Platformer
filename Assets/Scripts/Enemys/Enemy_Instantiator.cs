using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Instantiator : MonoBehaviour
{
    public List<GameObject> enemies;
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
            Instantiate(enemies[GameManager.actualPlayer], instantiatePos.transform);           
            respawningTimer = UnityEngine.Random.Range(3, 6);
        }
    }
}
