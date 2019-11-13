using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{

    //Attach this to the Player Character
    //health variables
    Image healthBar;
    public static float health;
    float maxHealth = 100f;
    //public Text healthText;
    
    
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / maxHealth;
    }
    
}
