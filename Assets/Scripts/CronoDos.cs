using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CronoDos : MonoBehaviour
{
    public TextMeshProUGUI labelTiempo;
    public float tiempo;
    public int starMinutes;
    public int starHoras;

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
}
