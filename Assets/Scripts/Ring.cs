using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//�����, ���������� �� ���� �����
public class Ring : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //����������� ��������� ������� ����
        //gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        //��� ����������� ������� ������� ������ ������ ������������
        Destroy(gameObject);
        //����� ���� ���������� ������ Score � ����������� ����
        Score.scoreAmount += 100;
    }
}