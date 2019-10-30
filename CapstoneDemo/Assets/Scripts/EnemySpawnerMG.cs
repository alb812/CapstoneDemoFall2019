using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerMG : MonoBehaviour
{
    
    //array of prefabs to spawn
    public GameObject shadowsPrefab;
    public GameObject itemPrefab;
    public GameObject[] enemy;
    public GameObject powerItem;
    
    //timer


    private void Start()
    {
        //in
               // Vector3 position = new Vector3(Random.Range(-6.0f, 6.0f), Random.Range(-6.0f, 6.0f), 0);
                    //Instantiate(itemPrefab, position, Quaternion.identity);
    }


    // Start is called before the first frame update
    void Awake()
    {
        enemy = new GameObject[5];
        for (int i = 0; i < enemy.Length; i++)
        {
            Vector3 position = new Vector3(Random.Range(-7.0f, 7.0f), Random.Range(-7.0f, 7.0f), 0);
           Instantiate(shadowsPrefab, position, Quaternion.identity); 
        }
       
       /* powerItem = new GameObject();
        for (int i = 0; i < enemy.Length;)
        {
            Vector3 position = new Vector3(Random.Range(-7.0f, 7.0f), Random.Range(-7.0f, 7.0f), 0);
            Instantiate(itemPrefab, position, Quaternion.identity);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        //if player touches item prefab
        //item disappears
        //shadows reset
    }
}
