using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour
{
    // Start is called before the first frame update
    public string dialogue;
    private DialogueManager dMan;

    public string[] dialogLines;
    
    //signal
    public Signal hintOn;
    public Signal hintOff;
    
    void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            hintOn.Raise();
            if (Input.GetKeyUp(KeyCode.Space))
            {
               // dMan.ShowBox(dialogue);
                if (!dMan.dialogueActive)
                {
                    dMan.dialogueLines = dialogLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();
                }
      
            }
        }
        else
        {
             hintOff.Raise();
        }
    }
}
