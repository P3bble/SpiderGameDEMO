using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class CoinManager : MonoBehaviour
{
    public int coinCount;
    public Text coinText;
    public GameObject Door;
    public GameObject Tri;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player collides with spider egg
        coinText.text = "Spider Eggs: " + coinCount.ToString();
      
        // If player has 7 eggs, destroy door 1

        if(coinCount == 7)
        {
            Destroy(Door);
        }
        
        // If player has 10 eggs, destroy door 2
        
        if(coinCount == 10)
        {
            Destroy(Tri);
        }
    }
}
