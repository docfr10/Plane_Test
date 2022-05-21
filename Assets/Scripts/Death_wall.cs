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

    public void NewGame()
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            SceneManager.LoadScene("Game");
        }
        else if (GameObject.FindGameObjectWithTag("Player2"))
        {
            SceneManager.LoadScene("Game2");
        }
    }

    public void Continue()
    {
        SceneManager.LoadScene("Game2");
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player2") || collision.gameObject.CompareTag("Player"))
        {
            DeadScreenUI.SetActive(true);
            Time.timeScale = 0f;
            rb.freezeRotation = true;
            if (GameObject.FindGameObjectWithTag("Player"))
            {
                audioSourcePropeller.GetComponent<PlayerController>().audioSourcePropeller.Stop();
            }
            else
            {
                audioSourcePropeller.GetComponent<Control2>().audioSourcePropeller.Stop();
            }
            audioSourceDead.Play();
            Debug.Log("You dead");
        }
    }
}
