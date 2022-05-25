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
}