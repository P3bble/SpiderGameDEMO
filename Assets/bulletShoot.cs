using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    // This function is called when the bullet collides with something
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the bullet collides with the spider
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Destroy spider
            Destroy(collision.gameObject);

            // Destroy the bullet
            Destroy(gameObject);
        }
    }
}