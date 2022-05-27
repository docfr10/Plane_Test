using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    [SerializeField] Canvas _canvas;
    public GameObject house, house2;//Нормальный и разрушенный дома
    public Camera cam1, cam2;
    public GameObject WinUI;

    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
        house.SetActive(true);
        house2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bomb"))
        {
            Destroy(house);
            house2.SetActive(true);
            cam1.enabled = false;
            cam2.enabled = true;
            WinUI.SetActive(true);
            Time.timeScale = 0f;
            _canvas.enabled = false;
        }
        else
        {
            print("Ты зачем самолет в дом направил?");
        }
    }
}
