using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMiniGameMovement : MonoBehaviour
{

    //for movement
    private Rigidbody2D playerMiniGame;
    public float moveSpeed;
    private Vector3 movement;

    //for UI
    public int currentHealth;
    public int maxHealth = 100;
    public int currentPower;
    public int startPower;
    public int maxPower = 100;

    public int score = 0;
    

    public GameObject shadows;


    // Start is called before the first frame update
    void Start()
    {
        playerMiniGame = GetComponent<Rigidbody2D>();

        //for UI
        currentHealth = maxHealth;
        currentPower = startPower;

    }

    // Update is called once per frame
    void Update()
    {
        movement = Vector3.zero;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (movement != Vector3.zero)
        {
            MoveCharacter();
            //Debug.Log("Player is moving!");
        }

        //for player health
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        //if player loses all health, Restart
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("PrototypeScene1");
        }
        
        //for player health
        if (currentPower > maxPower)
        {
            currentPower = maxPower;
        }
        
        if (currentPower == maxPower)
        {
            //boss appears
        }
    }

    private void MoveCharacter()
    {
        //playerMovement
        //Normalized == diagnol is same speed as horizontal and vertical
        playerMiniGame.MovePosition(transform.position + movement.normalized * moveSpeed * Time.deltaTime);
    }

    

    void OnTriggerEnter2D(Collider2D other)
    {
        //player loses a life when touched by enemy
        if (other.gameObject.CompareTag ("MiniGameItem"))
        {
            //makes the item inactive
           other.gameObject.SetActive(false);
           currentHealth += 25;
           HealthDisplay.health += 25f;
           currentPower += 25;
           PowerDisplay.power += 25f;
           score++;

            if (score < 3)
            {
                ResetMap();
            }
            
            if (score == 3)
            {
                BossAppears();
            }
            
            
           Debug.Log("Enemy has hit player!");
        }
        if (other.gameObject.tag == "Enemy")
        {
            //player touches enemy, they lose 25% health
            currentHealth -= 25;
            //Calls HeathDisplay script for change to health UI
            HealthDisplay.health -= 25f;
            Debug.Log("Enemy has hit player!");
        }
    }

    void ResetMap()
    {
        Destroy(shadows);
        //Update();
    }

    void BossAppears()
    {
        
    }

}
