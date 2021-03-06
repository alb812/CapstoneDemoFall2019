﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireball : MonoBehaviour
{
    //Put this on the fireball prefab
    
    float moveSpeed = 3f;

    //private target is enemy;

    private Transform target;
    
    public Rigidbody2D rb;

    private PlayerMiniGameMovement PlayerMoveScript;
    

    //BearScript target;
    
    private Vector3 speedRot = Vector3.right * 30f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Enemy").transform;
        //Destroy (gameObject, 3f);
        
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (speedRot * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        
    }
    
    void OnTriggerEnter2D (Collider2D col){
        //if enemy bullet hits player, it is destroyed
        if (col.gameObject.name == "Enemy") {
            Debug.Log ("Player bullet has hit Enemy!");
            //Destroy (this.gameObject);
        }
        //if enemy bullet hits ground, it is destroyed
        if (col.gameObject.tag == "Walls") {
            Debug.Log ("Hit surface!");
            //Destroy (instBullet);
        }
    }
}
