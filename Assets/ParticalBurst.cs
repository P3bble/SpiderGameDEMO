using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ParticalBurst : MonoBehaviour
{

    public ParticleSystem collisionParticalSystem;
    public SpriteRenderer sr;
    public bool once = true;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player") && once) {
          
            var em = collisionParticalSystem.emission;
            var dur = collisionParticalSystem.duration;

            em.enabled = true;
            collisionParticalSystem.Play();

            once = false;
            Destroy(sr);
            Invoke(nameof(DestroyObj), dur);

        }
    }

    void DestroyObj()
    {
        Destroy(gameObject);
    }

}
