using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpaceCount : MonoBehaviour
{
    public TextMeshProUGUI labelCuenta;
    public float timer = 5.0f;

    public int puntos=0;
    public TextMeshProUGUI labelPuntos;

    private void Start()
    {
        
    }


    void Update()
    {
        labelCuenta.text = timer.ToString("0.00");

        timer = timer - Time.deltaTime;
        
        if(timer<=0)
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyUp(KeyCode.Space) == true)
        {
            puntos = puntos + 1;
            labelPuntos.text = puntos.ToString();
           
        }
    }

   
}
