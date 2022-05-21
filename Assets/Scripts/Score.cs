using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//�����, ���������� �� ����������� �����
public class Score : MonoBehaviour
{
    public GameObject WinUI;
    //���� ������
    public static int scoreAmount;
    //����� �� ������
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    { 
        //���������� ���� ����� 0
        scoreAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText = GetComponent<Text>();
        //����� ������ �� �����
        scoreText.text = "��� ����: " + scoreAmount;
        if (scoreAmount == 1200)
        {
            WinUI.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("YOU WIN!");
        }
    }
}
