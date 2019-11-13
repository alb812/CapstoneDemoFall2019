using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeaconSpawner : MonoBehaviour
{
// put this on a large empty game object, it will spawn the beacon of light in the mini game
    public GameObject itemPrefab;

    public bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        if (isActive = true)
        {
            //item spawn
            Vector3 position = new Vector3(Random.Range(-6.0f, 6.0f), Random.Range(-6.0f, 6.0f), 0);
            Instantiate(itemPrefab, position, Quaternion.identity);
        }
    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
