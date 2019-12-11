using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    private float waitTime;
    public float startWaitTime;
    
    public Transform [] moveSpot;
    private int randomSpot;

    public int currentEnemyHealth;
    public int maxEnemyHealth = 100;
    
    
    void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpot.Length);
        
        currentEnemyHealth = maxEnemyHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        //moves bears to random empty gameobject called moveSpot
        transform.position =
            Vector2.MoveTowards(transform.position, moveSpot[randomSpot].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpot[randomSpot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpot.Length);
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
        
        if (currentEnemyHealth <= 0)
        {
           Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Fireball")
        {
            currentEnemyHealth -= 10;
            //Calls HeathDisplay script for change to health UI
            Debug.Log("Player has hit Enemy!");
        }
    }
}
