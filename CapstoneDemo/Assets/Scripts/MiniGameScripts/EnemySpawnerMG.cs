using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawnerMG : MonoBehaviour
{
    
    public GameObject[] SpawnPositions;
    private List <GameObject> SelectedSpawnPositions;
    public GameObject shadowPrefab;
        
    public PlayerMiniGameMovement PlayerScript;
    //Random rnd = new Random();
    //int randomIndex = 0;

    void Start()
    {
        SelectedSpawnPositions = new List<GameObject>();
        SelectSpawnPoints();
        SpawnShadows();
    }

    void SelectSpawnPoints()
    {
        for (int i = 0; i < 6; i++)
        {
            int randomNumber = Random.Range(0, SpawnPositions.Length);
            SelectedSpawnPositions.Add(SpawnPositions[randomNumber]);
        }
    }
    
    void SpawnShadows()
    {

        foreach (GameObject spawn in SelectedSpawnPositions)
        {
            GameObject spawnedShadow = Instantiate(shadowPrefab);
            spawnedShadow.transform.position = spawn.transform.position;
        }


        
        //TODO: look at using Instantiate(Resources.Load("Prefabs/PrefabName"))
//        foreach (GameObject SpawnPositions in SelectedSpawnPositions)
//        {
//            Instantiate(shadowPrefab);
//        }
    }
}
 
 
