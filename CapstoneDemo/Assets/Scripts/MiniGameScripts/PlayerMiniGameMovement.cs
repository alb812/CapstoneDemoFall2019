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
    public int currentSprint;
    public int maxSprint = 100;
    

    public int score = 0;
    
    EnemySpawnerMG EnemySpawnScript;

    public GameObject beaconLight;
    public GameObject shadows;   
    
    //dash
    private bool isCooldown;
    private float cooldown;
    public float timer;
    public float dashSpeed;
    
    private int direction;
    private float dashTime;
    public float startDashTime;
    
    
    //for player attack
    //For Enemy Shooting
    [SerializeField]
    GameObject bullet;
    float fireRate;
    float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        playerMiniGame = GetComponent<Rigidbody2D>();

        //for UI
        currentHealth = maxHealth;
        currentPower = 0;
        currentSprint = maxSprint;

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
        
        //for dash
        if (movement != Vector3.zero && Input.GetKey(KeyCode.Space))
        {
           // MoveCharacterDash();
            //Debug.Log("Player has dashed!");
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
        
        if (currentSprint > maxSprint)
        {
            currentSprint = maxSprint;
        }
        
        //for player health
        if (currentPower > maxPower)
        {
            currentPower = maxPower;
        }
        
        if (currentPower == maxPower)
        {
            //boss appears
            //BossAppears();
        }
        
        if (score < 3)
        {
           //Destroy(GameObject.FindWithTag("Enemy"));
            
            ////ResetMap();
        }

    }

    private void MoveCharacter()
    {
        //playerMovement
        //Normalized == diagnol is same speed as horizontal and vertical
        playerMiniGame.MovePosition(transform.position + movement.normalized * moveSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))// && currentSprint > 0)
        {
            StartCoroutine("DashMove");
        }
    }

    IEnumerator DashMove()
    {
        if (currentSprint > 0)
        {
            moveSpeed += 8;
            yield return new WaitForSeconds(.2f);
            moveSpeed -= 8;
            isCooldown = true;

            currentSprint -= 25;
            //Calls SprintDisplay script for change to health UI
            SprintDisplay.sprint -= 25f;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //player loses a life when touched by enemy
        if (other.gameObject.CompareTag("MiniGameItem")) 
        {
            if (score < 3)
            {
                //makes the item inactive
                other.gameObject.SetActive(false);
                Vector3 position = new Vector3(Random.Range(-6.0f, 6.0f), Random.Range(-6.0f, 6.0f), 0);
                Instantiate(beaconLight, position, Quaternion.identity);


                //sets stats
                currentHealth += 25;
                HealthDisplay.health += 25f;
                currentPower += 34;
                PowerDisplay.power += 34f;
                currentSprint = 100;
                SprintDisplay.sprint = 100;

                //increases internal score

                score++;
            }

            if (score == 3)
            {
                //makes item inactive
                other.gameObject.SetActive(false);
                Debug.Log("This is the attack phase");
                AttackPhase();
            }

        }

        if (other.gameObject.tag == "Enemy")
        {
            //player touches enemy, they lose 25% health
            currentHealth -= 10;
            //Calls HeathDisplay script for change to health UI
            HealthDisplay.health -= 10f;
            Debug.Log("Enemy has hit player!");
        }
    }
    
    //For attack phase
    void AttackPhase()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }

    void ResetMap()
    {
        //EnemySpawnScript.resetMap();
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }

    void BossAppears()
    {
        
    }
}

