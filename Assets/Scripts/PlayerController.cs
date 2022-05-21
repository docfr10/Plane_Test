using UnityEngine;
using System.Collections;

//Класс, отвечающий за управление самолетом
public class PlayerController : MonoBehaviour
{
    public GameObject NameCanvas;

    public GameObject BeginUI;
    public GameObject Prefab;
    public GameObject ScoreText;
    public float speed = 20f;

    public AudioSource audioSourcePropeller;
    public AudioSource audioSourceBegin;

    bool sw = false;

    // Update is called once per frame

    void Start()
    {
        Time.timeScale = 0f;
        audioSourcePropeller.Stop(); //Выключаю звук пропеллера
    }

    void Update()
    {
        if ((NameCanvas.activeSelf == false) && (Input.GetKey(KeyCode.Space)) && sw == false)
        {
            ScoreText.SetActive(true);
            Time.timeScale = 1f;
            BeginUI.SetActive(false);
            audioSourceBegin.Stop(); // Выключаю звук вступления
            audioSourcePropeller.Play(); //Включаю звук пропеллера
            sw = true;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(Prefab, transform.position, transform.rotation);
        }

        transform.position += transform.right * Time.deltaTime * speed;
        if (Input.GetButton("Fire1"))
            transform.position += transform.right * Time.deltaTime * 4f * speed;

        transform.Rotate(-Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

        float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight(transform.position);

        if (terrainHeightWhereWeAre > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x,
            terrainHeightWhereWeAre,
            transform.position.z);
        }
    }



    //void Update()
    //{

    //    transform.position += transform.right * Time.deltaTime * speed;

    //    speed -= transform.forward.y * Time.deltaTime * 50.0f;

    //    transform.Rotate(-Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

    //    float TerrainWhereWeAre = Terrain.activeTerrain.SampleHeight( transform.position );

    //    if(TerrainWhereWeAre > transform.position.y)
    //    {
    //        transform.position = new Vector3(transform.position.x,
    //                                         TerrainWhereWeAre,
    //                                         transform.position.z);
    //    }

    //    /*
    //    //При нажатии на ПРОБЕЛ игрок направляется вниз
    //    if (Input.GetKey(KeyCode.Space))
    //    {
    //        Player.transform.Rotate(0, 0, (float)-0.5 * Speed/2);
    //    }
    //    //При нажатии на SHIFT игрок направляется вверх
    //    if (Input.GetKey(KeyCode.LeftShift))
    //    {
    //        Player.transform.Rotate(0, 0, (float)0.5 * Speed/2);
    //    }
    //    //При нажатии на W игрок направляется вперед
    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        Player.transform.position += Player.transform.right * Speed*Speed * Time.deltaTime;
    //    }
    //    //При нажатии на Q игрок двигается влево вокруг своей оси
    //    if (Input.GetKey(KeyCode.Q))
    //    {
    //        Player.transform.Rotate((float)0.5 * Speed/2, 0, 0);
    //    }
    //    //При нажатии на E игрок двигается вправо вокруг своей оси
    //    if (Input.GetKey(KeyCode.E))
    //    {
    //        Player.transform.Rotate((float)-0.5 * Speed/2, 0, 0);
    //    }
    //    //При нажатии на A игрок направляется влево
    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        Player.transform.Rotate(0, (float)-0.5 * Speed/2, 0);
    //    }
    //    //При нажатии на D игрок направляется вправо
    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        Player.transform.Rotate(0, (float)0.5 * Speed/2, 0);
    //    }
    //    */
    //}
}