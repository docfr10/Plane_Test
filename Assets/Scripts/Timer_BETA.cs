using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_BETA : MonoBehaviour
{
    public float miliseconds;
    public float seconds;
    public float minutes;

    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        miliseconds += 0.005f;
        if (miliseconds >= 1)
        {
            seconds++;
            miliseconds = 0;
        }
        if (seconds >= 60)
        {
            minutes++;
            seconds = 0;
        }

        text.text = $"{minutes} : {seconds}";
    }

    public void test() 
    {
        
    }
}
