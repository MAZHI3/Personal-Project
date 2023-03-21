using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy1Prefab;
    public GameObject enemy2Prefab;
    public GameObject enemy3Prefab;
    public float spawnRange = 20;
    public float spawnPosZ = 20;
    public int enemyCount;
    public int waveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemy1Prefab, GenerateSpawnPosition(), enemy1Prefab.transform.rotation);
        Instantiate(enemy2Prefab, GenerateSpawnPosition(), enemy2Prefab.transform.rotation);
        Instantiate(enemy3Prefab, GenerateSpawnPosition(), enemy3Prefab.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        

    }



    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }
}