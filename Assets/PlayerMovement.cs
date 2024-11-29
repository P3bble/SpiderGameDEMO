using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //speed of player will be determined by public float
    public float normalSpeed = 5f;
    public float hideSpeed = 1f;

    public Rigidbody2D rb;
    //storing X and Y movement
    Vector2 movement;

    public Animator animator;
    public CoinManager cm;
    public power_ups pu;

    // shield mechanics
    public GameObject hide;
    public bool isHideActive = false;
    public bool isPickupGot = false;

   


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

        if (Input.GetKey(KeyCode.LeftShift) && isPickupGot == true)
        {
            hide.SetActive(true);
            isHideActive = true;
            normalSpeed = 1f;
        }
        else
        {
            hide.SetActive(false);
            isHideActive = false;
            normalSpeed = 5f;
        }


    }

    private void Start()
    {
        hide.SetActive(false);
    }

    private void FixedUpdate()
    {

        //movement
        rb.MovePosition(rb.position + movement * normalSpeed * Time.fixedDeltaTime);
    }



    void OnTriggerEnter2D(Collider2D other)
    {

        // Destroys egg if player collides with it

        if (other.gameObject.CompareTag("egg"))
        {
            
            cm.coinCount++;
        
        }

        if (other.gameObject.CompareTag("pickup"))
        {

            isPickupGot = true;
            Destroy(other.gameObject);


        }

        // Destroys golden egg if player collides with it

        if (other.gameObject.CompareTag("yellow_egg"))
        {
            Destroy(other.gameObject);
            cm.coinCount += 5;
        }

    }

   
}
