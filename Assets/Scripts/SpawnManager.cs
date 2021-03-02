using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public float spawnPosX = 12;
    private float spawnLimitYTop = 5.5f;
    private float spawnLimitYBottom = -3f;
    private float startDelay = 4;
    private float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnVulture", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnVulture()
    {
        Vector3 spawnPos = new Vector3(spawnPosX, Random.Range(spawnLimitYTop, spawnLimitYBottom), 0);
        Instantiate(enemy, spawnPos, enemy.transform.rotation);
    }
}
