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
    // Start is called before the first frame update
    void Start() => health = maxHealth;

    // Update is called once per frame
    void Update()
    {
        HEALTH.text = "Health: " + health.ToString();

    }
    public void TakeDamage(int ammount)
    {
        health -= ammount;
        if (health <= 0 )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
