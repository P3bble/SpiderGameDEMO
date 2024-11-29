using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletScript : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        
        playerMovement = player.GetComponent<PlayerMovement>();

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

        float rot = Mathf.Atan2(-direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 10)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other) // checks for damage, if sheild is up then dont do damage!
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (playerMovement != null && playerMovement.isHideActive == false)
            {
                other.gameObject.GetComponent<Player_Health>().health -= 1;
                Destroy(gameObject);
            }
        }
    }
}