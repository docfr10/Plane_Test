using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bomb : MonoBehaviour
{
    public AudioSource Explosion;
    Text scoreText;

    public static int scoreAmount;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        Explosion.Play();
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Score.scoreAmount += 300;
            Destroy(collision.gameObject);
            print("Work");
        }
    }
}
