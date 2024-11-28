using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_shooting : MonoBehaviour
{
    public GameObject e_bullet;
    public Transform e_bulletPos;


    private float timer;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        Debug.Log(distance);

        if(distance < 9)
        {
            timer += Time.deltaTime;
 if (timer > 2)
        {
            timer = 0;
            shoot();
        }
        }
        
       
    }
    void shoot()
    {
        Instantiate(e_bullet, e_bulletPos.position, Quaternion.identity);
    }
}
