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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Spider Eggs: " + coinCount.ToString();
        if(coinCount == 6)
        {
            Destroy(Door);
        }
    }
}
