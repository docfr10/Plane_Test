using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraftcarrier : MonoBehaviour
{
    public GameObject WinUI;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player2") || collision.gameObject.CompareTag("Player"))
        {
            WinUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
