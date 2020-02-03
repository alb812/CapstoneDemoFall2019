using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawnerMG : MonoBehaviour
{
    
  /* //array of prefabs to spawn
  // public GameObject shadowsPrefab;
   //public GameObject[] enemy;
    //make prefab a gameobject so it can be deleted
   //private GameObject enemiesGO;
   // private bool isActive;

    public List<GameObject> spawnPositions;
    public List<GameObject> spawnObjects;
    
   // public GameObject powerItem;

    private int phase;
    
    //timer
    public int timeLeft = 15;


    private void Start()
    {
        //makes the prefab a gameobject
       // enemiesGO = shadowsPrefab;

        // isActive = false;

        phase = 1;

        if(phase == 1)
        {
        SpawnWave1Objects();
        }

        //starts timer
        StartCoroutine("LoseTime");
        Time.timeScale = 1; //Just making sure that the timeScale is right
    }
    


    IEnumerator LoseTime()
        {
            while (true)
            {
                yield return new WaitForSeconds(1);
                timeLeft--;
            }
        }
    

    void Update()
        {

            if (timeLeft == 0)
            {
               // isActive = false;
                //resetMap();
                Debug.Log("Timer has reached 0");
            }

        }

    void SpawnWave1Objects()
    {
        
        foreach(GameObject spawnPosition in spawnPositions)
        {
            //int selection = Random.Range(0, spawnObjects.Count);
           // Vector3 position = new Vector3(Random.Range(-3.0f, 3.0f), Random.Range(-3.0f, 3.0f), 0);
           //Instantiate(spawnObjects[selection], position, Quaternion.identity);
            
            
          int selection = Random.Range(0, spawnObjects.Count);
          Instantiate(spawnObjects[selection], spawnPosition.transform.position, spawnPosition.transform.rotation);
        }
    }


        void resetMap()
        {


           // Destroy(enemiesGO);
            
            Debug.Log("Shadows should be destroyed...");

        }
    }




/* Old Code Cleanup
  //item spawn
        //  Vector3 position = new Vector3(Random.Range(-6.0f, 6.0f), Random.Range(-6.0f, 6.0f), 0);
        // Instantiate(itemPrefab, position, Quaternion.identity);

        //instantiates 5 shadows
        //enemy = new GameObject[5];

        //Meeting notes: change spawn so that it remains randomized but each shadow and the item
        //has a specific range in which they spawn


        //instantiates the shadows in random locations
        /* for (int i = 0; i < enemiesGO.length; i++)
         {
             Vector3 position = new Vector3(Random.Range(-7.0f, 7.0f), Random.Range(-7.0f, 7.0f), 0);
             Instantiate(enemiesGO, position, Quaternion.identity);
         }*/

// for (int i = 0; i < enemiesGO; i++)
//{
// Vector3 position = new Vector3(Random.Range(-3.0f, 3.0f), Random.Range(-3.0f, 3.0f), 0);
//Instantiate(enemiesGO, position, Quaternion.identity);
//}*/

    public Transform[] spawnPoints;
    public GameObject[] prefabs;
    public float minTime, maxTime;
    public int numberOfSpawns = 5;
 
    private float timer = 0f;
    private int lastSpawnPointIndex = -1;
 
    private void Update()
    {
        if (timer <= 0f)
        {
            SpawnItems();
            ResetTimer();
        }
        timer -= Time.deltaTime;
    }
 
    private void SpawnItems()
    {
        for (int i = 0; i < numberOfSpawns; i++)
        {
            Transform spawnPoint = GetNextSpawnPoint();
            GameObject prefab = prefabs[Random.Range(0, prefabs.Length)];
            Instantiate(prefab, spawnPoint);
        }
    }
 
    private Transform GetNextSpawnPoint()
    {
        // We want a random index from the error, but not the same as last time.
        // So we at least more one index further and stop one index before the last.
        // The % operator loops back to the beginning of zero, if the index overshoots the array length.
        int index = (lastSpawnPointIndex + Random.Range(1, spawnPoints.Length - 1)) % spawnPoints.Length;
        lastSpawnPointIndex = index;
        return spawnPoints[index];
    }
 
    private void ResetTimer()
    {
        timer = Random.Range(minTime, maxTime);
    }
}
 
 
