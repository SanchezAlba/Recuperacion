using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VidaController : MonoBehaviour
{
    public Slider sliderVida;

    public GameObject botonVida;
    public GameObject botonReiniciar;
    public string gameOver;
  
    void Start()
    {
        sliderVida.value = 5;
        gameOver = "";
       
    }

    void Update()
    {
       if(sliderVida.value==0)
        {
            gameOver = "gameOver";
        }
    }


    public void RestarVida()
    {
        sliderVida.value = sliderVida.value-1;
      
    }


    public void Reiniciar()
    {
        sliderVida.value = 5;
    }


}
