using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //speed of player will be determined by public float
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    //storing X and Y movement
    Vector2 movement;

    public Animator animator;
    public CoinManager cm;

   


    // Update is called once per frame
    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        //animation
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {

        //movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }


    void OnTriggerEnter2D(Collider2D other)
    {

        // Destroys egg if player collides with it

        if (other.gameObject.CompareTag("egg"))
        {
            
            cm.coinCount++;
        
        }

        // Destroys golden egg if player collides with it

        if (other.gameObject.CompareTag("yellow_egg"))
        {
            Destroy(other.gameObject);
            cm.coinCount += 5;
        }

    }
   
}
