using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] SpawnPositions;
    private List <GameObject> SelectedSpawnPositions;
    public GameObject BearsPrefab;
   
    void Start()
    {
        SelectedSpawnPositions = new List<GameObject>();
        SelectSpawnPoints();
        SpawnBears();
    }

    void SelectSpawnPoints()
    {
        for (int i = 0; i < 2; i++)
        {
            int randomNumber = Random.Range(0, SpawnPositions.Length);
            SelectedSpawnPositions.Add(SpawnPositions[randomNumber]);
        }
    }
    
    void SpawnBears()
    {
        foreach (GameObject spawn in SelectedSpawnPositions)
        {
            GameObject spawnedBears = Instantiate(BearsPrefab);
            spawnedBears.transform.position = spawn.transform.position;
        }
    }
}
