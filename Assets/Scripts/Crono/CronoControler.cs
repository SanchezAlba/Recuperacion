using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CronoControler : MonoBehaviour
{
    public TextMeshProUGUI labelCrono;
    public TextMeshProUGUI labelPlay;
    public TextMeshProUGUI labelResult;

    public float cronometro = 0.0f;
    public bool isActive = false;

    void Update()
    {
        if (isActive == true)
        {
            labelCrono.text = cronometro.ToString("0.00");
            cronometro += Time.deltaTime;
        }
    }

    public void ClickPlayButton()
    {
        if (isActive = !isActive)
        {
            labelPlay.text = "soltar balon";
        }
        else
        {
            labelPlay.text = "jugar";
            labelResult.text = GetResult(cronometro);
        }
    }

    public float GetDecimals(float number)
    {
        return number % 1;
    }

    public string GetResult(float time)
    {
         string resultado = "mostrar resultado jugada";
        float decimals = GetDecimals(time);

        if (decimals >= 0.0f & decimals <= 0.25f)
        {
            resultado = "GOOL!";
        }

        else if (decimals >= 0.26f & decimals <= 0.80f)
        {
            resultado = "Pierde la pelota";
        }
        
        else
        {
            resultado = "falta";
        }

        return resultado;
    }
}