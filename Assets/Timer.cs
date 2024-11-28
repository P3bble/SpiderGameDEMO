using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 60;
    public Text Timer_TextDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer_TextDisplay.text = "Time:" + timer;

        
        timer -= +Time.deltaTime;
        if(timer <=0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
