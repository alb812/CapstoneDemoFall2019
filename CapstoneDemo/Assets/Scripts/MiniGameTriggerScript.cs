﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameTriggerScript : MonoBehaviour
{
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
        //player loses a life when touched by enemy
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("CombatMiniGamePrototypeDemon");
        }
    }
}
