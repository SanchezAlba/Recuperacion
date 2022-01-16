using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class CountDown : MonoBehaviour
{
    public float timer = 5f;
    public float minTimer = 0;
    public TextMeshProUGUI labelTimer;
    public TextMeshProUGUI labelRestart;

    public TMP_InputField tiempo;

    public AudioSource musica;
    public bool isActive = true;


    void Update()
    {
        
        //float timer = float.Parse(tiempo.text);
        

        if (timer>minTimer)
        {
            timer = timer - Time.deltaTime;
            labelTimer.text = timer.ToString("0.0");
            musica.Pause();
            isActive = true;
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
       labelTimer.text = timer.ToString("0.0");
    }

    public void Pause()
    {
        
    }
}
