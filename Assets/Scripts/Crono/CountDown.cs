using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CountDown : MonoBehaviour
{
    public float timer = 5f;
    public TextMeshProUGUI labelTimer;
    public AudioSource musica;
    public bool isActive = false;

    private void Start()
    {
       
    }

    void Update()
    {
       
        timer = timer - Time.deltaTime;
        labelTimer.text = timer.ToString("0.0");

        if (timer <= 0)
        {
            Destroy(gameObject);
        }

        if (timer==0)
        {
            musica.Play();
        }
    }
}
