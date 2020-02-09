using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum DoorType
    {
        basic,
        key, 
        enemy, 
        button
    }

public class DoorScript : InteractableScript
{
    // Start is called before the first frame update
    [Header("Door Variables")]
    public DoorType ThisDoorType;
    public bool open = false;
    //public Invertory playerInventory;
    public GameObject BasicDoor;
    public SpriteRenderer doorSprite;
    public BoxCollider2D BoxCollider;

    private void Start()
    {
        BasicDoor = GetComponent<GameObject>();
    }

    private void Update()
    {
        //if player touches space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (PlayerInRange && ThisDoorType == DoorType.basic)
            {
                OpenDoor();
            }
        }
        else if(!PlayerInRange)
        {
            CloseDoor();
        }
    }

    public void OpenDoor()
         {
             open = true;
             doorSprite.enabled = false;
             BoxCollider.enabled = false;
         }
    public void CloseDoor()
    {
        open = false;
        doorSprite.enabled = true;
        BoxCollider.enabled = true;
    }
}
