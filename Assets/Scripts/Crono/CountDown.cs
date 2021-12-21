using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CountDown : MonoBehaviour
{
    public float timer = 5f;
    public float minTime = 0.0f;
    public TextMeshProUGUI labelTimer;
    public TextMeshProUGUI labelRestart;

    public AudioSource musica;
    public bool isActive = true;
    public bool time = true;

    private void Start()
    {
       
    }

    void Update()
    {
       if(timer> minTime)
        {
            timer = timer - Time.deltaTime;
        }

        labelTimer.text = timer.ToString("0.0");
       

        if (timer == 0 ) // hacer que se pare en CERO
        {
           
            timer = minTime;
        }

        if (timer<=0 && isActive==true) 
        {
            musica.Play(); // la musica no sonaba porque estaba en el bucle infinito, entonces el timepo volviuas y todo eso
            isActive = false;
        }

    }

    public void restart()
    {
        timer = 5.0f;
       labelRestart.text = timer.ToString("0.0");
    }

    public void Pause()
    {
        
    }
}
