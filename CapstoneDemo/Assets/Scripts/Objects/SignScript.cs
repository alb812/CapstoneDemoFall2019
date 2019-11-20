using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignScript : InteractableScript
{
    // Start is called before the first frame update
    
    
    public GameObject dialogueBox;
    public Text dialogueText;
    public string dialogue;
  
    
    void Start()
    {
        //deactivates dialogue box when scene starts
        dialogueBox.SetActive(false);
    }

    // Update is called once per frame
    public virtual void Update()
    {
        //if the player is in range and presses SPACE
        if (Input.GetKey(KeyCode.Space) && PlayerInRange)
        {
            //Activates dialogue box with text set in the INSPECTOR
                dialogueBox.SetActive(true);
                dialogueText.text = dialogue;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //If player exits box collider
        if (other.CompareTag("Player"))
        {
            hintOff.Raise();
            //Sets to false
            Debug.Log("Player not in radius");
            PlayerInRange = false;
            //AND removes dialogue box
            dialogueBox.SetActive(false);
        }
    }
    
}
