using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class Player_Health : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;
    public Text HEALTH;
   

    public PlayerMovement PlayerMovement;  // Reference to playermovement
    public GameObject hide;  // Reference to the hide GameObject

    // Start is called before the first frame update
    void Start() => health = maxHealth;
    

    // Update is called once per frame
    void Update()
    {
        HEALTH.text = "Health: " + health.ToString();

        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void TakeDamage(int ammount)
    {


        if (PlayerMovement.isHideActive == false)
        {
            health -= ammount;
        }

           

        if (health <= 0 )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
