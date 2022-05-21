using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Класс, отвечающий за игровые настройки
public class Settigs : MonoBehaviour
{
    //Объекты, отвечающие за качество и разрешение
    public Dropdown dropdownRes, dropdownQua;
    //Галочка для выбора режима экрана
    public Toggle toggle;
    //Массив куда будут записаны все разрешения экрана
    Resolution[] res;

    public void Start()
    {
        //Изначально выбран полноэкранный режим
        Screen.fullScreen = true;
        //Галочка оконного режима отключена изначально
        toggle.isOn = false;

        //Изначально все варианты качества очищены
        dropdownQua.ClearOptions();
        //После чего все доступные варианты были загружены в настройки
        dropdownQua.AddOptions(QualitySettings.names.ToList());
        //Функция, позволяющая пользователю выбрать качество игры
        dropdownQua.value = QualitySettings.GetQualityLevel();

        //Все доступные разрешения были загружены в массив
        Resolution[] resolution = Screen.resolutions;
        res = resolution.Distinct().ToArray();
        //Массив для отображения разрешения экрана на экране пользователя
        string[] strRes = new string[res.Length];
        for (int i = 0; i < res.Length; i++) 
        {
            strRes[i] = res[i].width.ToString() + "x" + res[i].height.ToString();
        }

        dropdownRes.ClearOptions();
        dropdownRes.AddOptions(strRes.ToList());
        dropdownRes.value = res.Length - 1;

        Screen.SetResolution(res[res.Length - 1].width, res[res.Length - 1].height, Screen.fullScreen);
    }
    void Update()
    {

    }
    //Выбор разрешения пользователем
    public void setRes()
    {
        Screen.SetResolution(res[dropdownRes.value].width, res[dropdownRes.value].height, Screen.fullScreen);
    }
    //Выбор режима экрана пользователем
    public void FullScreenToggle()
    {
        Screen.fullScreen = !toggle.isOn;
    }
    //Выбор качества пользователем
    public void SetQuality()
    {
        QualitySettings.SetQualityLevel(dropdownQua.value);
    }
    //Объект, отвечающий за воспроизведение аудио
    public AudioMixer am;
    public void AudioVolume(float sliderValue)
    {
        am.SetFloat("masterVolume", sliderValue);
    }
}
