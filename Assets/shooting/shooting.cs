using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint; 
    public float bulletSpeed = 10f;
    public float fireRate = 0.5f;

    private float nextFireTime = 0f;

    void Update()
    {
        // Check if the fire button is pressed and the cooldown period has passed

        if (Input.GetButton("Fire1") && Time.time >= nextFireTime)
        {
            Shoot();
            // resets time

            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
      // Direction of prefab

        Vector3 shootDirection = firePoint.up;


        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Rotation

        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();

        // Direction

        bulletRb.velocity = shootDirection * bulletSpeed;

      // Destroy bullet

        Destroy(bullet, 5f);
    }
}