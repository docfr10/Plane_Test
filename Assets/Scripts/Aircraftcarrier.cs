using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Aircraftcarrier : MonoBehaviour
{
    public GameObject WinUI;

    public float speed;
    public float time;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.right * Time.deltaTime * speed);
    }

    public void OnCollisionStay(Collision collision)
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Game3":
                if (collision.gameObject.CompareTag("Player2"))
                {
                    time += Time.deltaTime;
                    if (time > 10)
                    {
                        WinUI.SetActive(true);
                        Time.timeScale = 0f;
                    }
                }
                break;
        }
    }
}
