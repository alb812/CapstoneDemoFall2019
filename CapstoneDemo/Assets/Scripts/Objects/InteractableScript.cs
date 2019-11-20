using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableScript : MonoBehaviour
{
    public Signal hintOn;
    public Signal hintOff;
    
    public bool PlayerInRange;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        //If player enters box collider
        if (other.CompareTag("Player"))
        {
            
            //shows hint
            hintOn.Raise();
            //Sets to true
            Debug.Log("Player in radius");
            PlayerInRange = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        //If player exits box collider
        if (other.CompareTag("Player"))
        {
            hintOff.Raise();
            //Sets to false
            Debug.Log("Player not in radius");
            PlayerInRange = false;
            //AND removes dialogue box
        }
    }
    
}
