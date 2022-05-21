using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Класс, отвечающий за отображение счета
public class Score : MonoBehaviour
{
    public GameObject WinUI;
    //Счет игрока
    public static int scoreAmount;
    //Текст на экране
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    { 
        //Изначально счет равен 0
        scoreAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText = GetComponent<Text>();
        //Вывод текста на экран
        scoreText.text = "Ваш счет: " + scoreAmount;
        if (scoreAmount == 1200)
        {
            WinUI.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("YOU WIN!");
        }
    }
}
