using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject dbox;
    public Text dText;

    public bool dialogueActive;

    public string[] dialogueLines;
    public int currentLine;

    private PlayerMovement thePlayer;
    
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueActive && Input.GetKeyDown(KeyCode.Space))
        {
            //dbox.SetActive(false);
            //dialogueActive = false;

            currentLine++;
        }

        if (currentLine >= dialogueLines.Length)
        {
            dbox.SetActive(false);
            dialogueActive = false;

            currentLine = 0;
            thePlayer.CanMove = true;
        }

        dText.text = dialogueLines[currentLine];
    }

    public void ShowBox(string dialogue)
    {
        dialogueActive = true;
        dbox.SetActive(true);
        dText.text = dialogue;
    }

    public void ShowDialogue()
    {
        dialogueActive = true;
        dbox.SetActive(true);
        thePlayer.CanMove = false;
    }
}
