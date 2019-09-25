using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D player;

    public float moveSpeed;

    private Vector3 movement;
   
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
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
        }
        Debug.Log("change");
    }

    private void MoveCharacter()
    {
        player.MovePosition(transform.position + movement * moveSpeed * Time.deltaTime);
    }
}
