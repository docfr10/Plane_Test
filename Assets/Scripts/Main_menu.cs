using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//�����, ���������� �� ������� ����
public class Main_menu : MonoBehaviour
{
    public void Start()
    {
        
    }
    //������, ���������� �� ������ ����
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
    //������, ���������� �� ����� �� ����
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
}
