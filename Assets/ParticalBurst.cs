using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ParticalBurst : MonoBehaviour
{

    public ParticleSystem collisionParticalSystem; // this gets the correct partical system (can put this in the script to connect)
    public SpriteRenderer spriteofpartical; // this gets the sprite renderer (of coins (spider eggs))
    public bool once = true;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player") && once) {

            // collision between the player, as tagged, and the object which the script is on (spider egg)
          
            var em = collisionParticalSystem.emission;
            var dur = collisionParticalSystem.main.duration; // duration can be changed here

            em.enabled = true;
            collisionParticalSystem.Play(); // once collided then play system, change to false

            once = false; // once false, destroys partical, called to destroy the object
            Destroy(spriteofpartical);
            Invoke(nameof(DestroyObj), dur);

        }
    }

    void DestroyObj() // destroys object
    {
        Destroy(gameObject);
    }

}
