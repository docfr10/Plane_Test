using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Класс, отвечающий за сбор очков
public class Ring : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Присваиваем чекпоитам красный цвет
        //gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        //При прохождении игроком объекта данный объект уничтожается
        Destroy(gameObject);
        //После чего вызывается скрипт Score и начисляются очки
        Score.scoreAmount += 100;
    }
}