using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    // This function is called when the bullet collides with something
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the bullet collides with the target sprite (e.g., an enemy)
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Destroy the enemy sprite
            Destroy(collision.gameObject);

            // Destroy the bullet itself after the collision
            Destroy(gameObject);
        }
    }
}