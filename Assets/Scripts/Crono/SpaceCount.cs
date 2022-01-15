using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SpaceCount : MonoBehaviour
{
    public TextMeshProUGUI labelCuenta;
    public float timer = 5.0f;
    public float minTimer = 0.0f;

    public int puntos=0;
    public TextMeshProUGUI labelPuntos;

    public Slider sliderTiempo;

    private void Start()
    {
        sliderTiempo.maxValue = timer;
        
    }


    void Update()
    {
        if (timer > minTimer)
        {
            timer = timer - Time.deltaTime;

            if (Input.GetKeyUp(KeyCode.Space) == true)
            {
                puntos = puntos + 1;
            }
        }
        labelCuenta.text = timer.ToString("0.00");

        if(timer<=0)
        {
            labelPuntos.text = puntos.ToString();
            
        }

        sliderTiempo.value = timer;

    }

    public void Restart()
    {
        timer = 5.0f;
        timer = timer - Time.deltaTime;
        puntos = 0;
    }
}
