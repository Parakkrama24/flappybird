using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject wallPrefab;
    public float spawnRate = 2f;
    public float spawnDelay = 2f;
    public float spawnHeight = 3f;
    public float gapSize = 2f;

    private float timer = 0f;
    public Game_manegerScript gameMangerSc;

    void Update()
    {
        timer = timer+Time.deltaTime;

        if (timer > spawnDelay)
        {
            SpawnWall();
            //int k;
           // spawnDelay -= 0.02f;
            timer = 0f;
        }
       /* if (spawnDelay <=1.5)
        {
            Time.timeScale = 0;
          //  gameMangerSc.newLevel();
        }*/
    }

    void SpawnWall()
    {
        float y = Random.Range(-spawnHeight, spawnHeight);

        Vector3 spawnPos = transform.position + new Vector3(0f, y, 0f);
        GameObject wall1 = Instantiate(wallPrefab, spawnPos, Quaternion.identity);
        //gapSize=Random.Range(3, 5);
       // Vector3 spawnPos2 = spawnPos + new Vector3(0f, y + gapSize, 0f);
        //GameObject wall2 = Instantiate(wallPrefab, spawnPos2, Quaternion.identity);

        Destroy(wall1, 10f);
        //Destroy(wall2, 10f);
    }
}
