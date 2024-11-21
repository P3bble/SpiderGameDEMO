using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;  // Bullet prefab to spawn
    public Transform firePoint;  // The point from which the bullet will spawn (e.g., in front of the player)
    public float bulletSpeed = 10f;  // Speed of the bullet
    public float fireRate = 0.5f;  // Time between shots

    private float nextFireTime = 0f;  // Time tracking when the next shot can be fired

    void Update()
    {
        // Check if the fire button is pressed and the cooldown period has passed
        if (Input.GetButton("Fire1") && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;  // Reset the next fire time based on the fire rate
        }
    }

    void Shoot()
    {
        // Get the player's rotation and the direction the player is facing (firepoint rotation)
        Vector3 shootDirection = firePoint.up;  // Firepoint's up vector should be aligned with the player's rotation

        // Create the bullet at the firepoint's position and rotation
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Get the Rigidbody2D component of the bullet
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();

        // Set the bullet's velocity in the direction the firepoint is facing
        bulletRb.velocity = shootDirection * bulletSpeed;

        // Destroy the bullet after a few seconds to avoid cluttering the scene
        Destroy(bullet, 5f); // Bullet will be destroyed after 5 seconds
    }
}