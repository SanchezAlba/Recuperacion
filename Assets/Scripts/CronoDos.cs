using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CronoDos : MonoBehaviour
{
    public TextMeshProUGUI labelTiempo;
    public float tiempo;
    public float minutes;
    public float restoMinutes;
    public float restoHoras;
    public float starHoras;
    public float starSegundos;

    public bool isActive = true;
    

    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive==true)
        {
            labelTiempo.text = tiempo.ToString("0.0");
            tiempo += Time.deltaTime;
        }

      
    }


    public void botonPausa()
    {

        isActive = !isActive;
    }


    public void BotonReiniciar()
    {
        tiempo = 0.00f;
        labelTiempo.text = tiempo.ToString();
    }

    public string ConvertToStringTime(float t)
    {
        string tiempoEnString="";

        int nHoras = ((int)t) / 3600; //convierte t(float) en int 
        float segundos = t % 3600f;
    
        int nMinutos = (int)segundos / 60;
        int nSegundos = (int)segundos % 60;

        float decimales = t - (int)t; // al tiempo el resta la parte enterta

        tiempoEnString = nHoras + ":" + nMinutos + ":" + nSegundos.ToString("0.0") + "" + ":" + (decimales * 100) + ":";

        return tiempoEnString;
    } 

}
