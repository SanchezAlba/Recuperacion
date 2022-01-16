using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MusicaEj4 : MonoBehaviour
{
    public Slider sliderVolumen;
    public Slider sliderPitch;
    public Slider sliderProgresoCancion;

    public GameObject botonPausa;
    
    public GameObject fotoPlay;
    public GameObject fotoPause;

    public AudioSource musica;


    void Start()
    {

        sliderVolumen.value = 1;
        sliderPitch.value = 1;
        fotoPlay.SetActive(false);
    }


    void Update()
    {
        if(musica.isPlaying)
        {
            sliderProgresoCancion.value += Time.deltaTime;
        }

        musica.time = sliderProgresoCancion.value;
    }

    public void Volumen()
    {
        sliderVolumen.value = musica.volume;
    }

    public void Pitch()
    {
        sliderPitch.value = musica.pitch;
    }

    public void Pausa()
    {
        if(musica.isPlaying)
        {
            musica.Pause();
            fotoPause.SetActive(false);
            fotoPlay.SetActive(true);
        }
        else
        {
            musica.Play();
            fotoPause.SetActive(true);
            fotoPlay.SetActive(false);
        }
    }

   public void Progreso()
    {
        sliderProgresoCancion.value = musica.time;
    }
   

}
