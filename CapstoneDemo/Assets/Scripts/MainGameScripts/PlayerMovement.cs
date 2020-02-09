using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D player;

    public float moveSpeed;

    private Vector3 movement;

    private Animator animator;

    public bool CanMove;
    private bool playerMoving;

    public VectorValue startingPos;
    
   
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GetComponent<Rigidbody2D>();
        CanMove = true;
        transform.position = startingPos.initialValue;
    }

    // Update is called once per frame
    void Update()
    {

        playerMoving = false;
        
        if (CanMove = true)
        {
           movement = Vector3.zero;
                   movement.x = Input.GetAxisRaw("Horizontal");
                   movement.y = Input.GetAxisRaw("Vertical");
                   UpdateAnimationMove();
                   Debug.Log("Player is moving!");
        }

        if (!CanMove)
        {
            player.velocity = Vector2.zero;
            return;
        }
    }

    void UpdateAnimationMove()
    {
         if (movement != Vector3.zero)
                {
                    MoveCharacter();
                    animator.SetFloat("MoveX", movement.x);
                    animator.SetFloat("MoveY", movement.y);
                    animator.SetBool("Moving", true);
                }
                else
                {
                    animator.SetBool("Moving", false);
                }
    }

    private void MoveCharacter()
    {
        //playerMovement
        //Normalized == diagnol is same speed as horizontal and vertical
        player.MovePosition(transform.position + movement.normalized * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Interactables") && Input.GetKey(KeyCode.Space))
        {
            CanMove = false;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (CanMove == false && Input.GetKey(KeyCode.Space))
        {
            CanMove = true;
        }
    }
    
    
    
}
