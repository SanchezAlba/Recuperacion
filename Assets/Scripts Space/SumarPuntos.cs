using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SumarPuntos : MonoBehaviour
{
    public TextMeshProUGUI labelPuntos;
    public int puntos = 0;
    public int puntosTotales=0;

    
    void Start()
    {
        labelPuntos.text = puntosTotales.ToString();
        puntosTotales += puntos;
    }

    
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            puntos += 5;
            puntosTotales += puntos;
        }

        labelPuntos.text = puntosTotales.ToString();
    }
}
