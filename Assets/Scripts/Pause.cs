using UnityEngine;
using UnityEngine.SceneManagement;

//Класс, отвечающий за меню паузы
public class Pause : MonoBehaviour
{
    //Параметр, отвечающий за то, на паузе ли игра
    public static bool GameIsPause = false;

    //Объект меню паузы
    public GameObject pauseMenuUI;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
            {
                Resume();
            }
            else
            {
                Pause_m();
            }
        }
    }

    //Скрипт, отвечающий за продолжение игры из меню паузы
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    } 

    //Скрипт, отвечающий за включение меню паузы
    public void Pause_m()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    //Скрипт, отвечающий за выход в главное меню
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    //Скрипт, отвечающий за выход из игры
    public void Exit()
    {
        Application.Quit();
    }
}