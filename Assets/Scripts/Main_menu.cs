using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Класс, отвечающий за главное меню
public class Main_menu : MonoBehaviour
{
    public void Start()
    {
        
    }
    //Скрипт, отвечающий за запуск игры
    public void NewGame1()
    {
        SceneManager.LoadScene("Game");
    }
    public void NewGame2()
    {
        SceneManager.LoadScene("Game2");
    }
    public void NewGame3()
    {
        SceneManager.LoadScene("Game3");
    }
    //Скрипт, отвечающий за выход из игры
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
}
