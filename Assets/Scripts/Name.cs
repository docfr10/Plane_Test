using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public GameObject Controlling;
    public GameObject NameCanvas;
    public InputField NameText;

    public GameObject ScoreText;
    public GameObject BeginUI;
    public AudioSource audioSourcePropeller;
    public AudioSource audioSourceBegin;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Yes()
    {
        NameCanvas.SetActive(false);
        Controlling.SetActive(true);
        ScoreText.SetActive(true);
        Time.timeScale = 1f;
        BeginUI.SetActive(false);
        audioSourceBegin.Stop(); // Выключаю звук вступления
        audioSourcePropeller.Play(); //Включаю звук пропеллера
    }

    public void No()
    {
        NameCanvas.SetActive(false);
        Controlling.SetActive(true);
    }
}
