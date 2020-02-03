using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTriggerScript : MonoBehaviour
{
    // Start is called before the first frame update\

    private QuestManager theQM;

    public int questNumber;

    public bool startQuest;
    public bool endQuest;
    
    void Start()
    {
        theQM = FindObjectOfType<QuestManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   // private void OnTriggerEnter2D(Collider2D other)
   // {
       /* if (other.gameObject.name == "Player")
        {
            if (!theQM.questCompleted[questNumber])
            {
                if (startQuest && !theQM.quests[questNumber].gameObject.activeSelf)
                {
                    theQM.quests[questNumber].gameObject.SetActive(true);
                    theQM.quests[questNumber].StartQuest();
                }
            }
        }*/
        
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !theQM.questCompleted[questNumber])

        {
            if(startQuest && !theQM.quests[questNumber].gameObject.activeSelf)
            {
                theQM.quests[questNumber].gameObject.SetActive(true);
                theQM.quests[questNumber].StartQuest();
            }

            if(endQuest && theQM.quests[questNumber].gameObject.activeSelf)
            {
                theQM.quests[questNumber].EndQuest();
            }
           
        }
    }
}
