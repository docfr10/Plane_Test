using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death_wall : MonoBehaviour
{
    public GameObject DeadScreenUI;
    private GameObject player;
    public AudioSource audioSourceDead;
    public AudioSource audioSourcePropeller;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player = GameObject.FindGameObjectWithTag("Player2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void NewGame() // Используется при проигрыше на уровне чтобы начать его заново
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Game":
                SceneManager.LoadScene("Game");
                break;
            case "Game2":
                SceneManager.LoadScene("Game2");
                break;
            case "Game3":
                SceneManager.LoadScene("Game3");
                break;
            case "Game4":
                SceneManager.LoadScene("Game4");
                break;
        }
    }

    public void Continue() // Используется чтобы перейти на следующий уровень
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Game":
                SceneManager.LoadScene("Game2");
                break;
            case "Game2":
                SceneManager.LoadScene("Game3");
                break;
            case "Game3":
                SceneManager.LoadScene("Game4");
                break;
        }        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player2") || collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Player3"))
        {
            DeadScreenUI.SetActive(true);
            Time.timeScale = 0f;
            rb.freezeRotation = true;
            if (GameObject.FindGameObjectWithTag("Player"))
            {
                audioSourcePropeller.GetComponent<PlayerController>().audioSourcePropeller.Stop();
            }
            else if (GameObject.FindGameObjectWithTag("Player2"))
            {
                audioSourcePropeller.GetComponent<Control2>().audioSourcePropeller.Stop();
            }
            else if (GameObject.FindGameObjectWithTag("Player3"))
            {
                //audioSourcePropeller.GetComponent<Control3>().audioSourcePropeller.Stop();
            }
            audioSourceDead.Play();
            Debug.Log("You dead");
        }
    }
}
