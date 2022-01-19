using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Vida : MonoBehaviour
{
    float currentLife = 10;
    public SliderController sliderController; // llama al otro script

    public void ModificadorVida(float amount)
    {
        currentLife += amount;
        if(currentLife<=0)
        {
            Debug.Log("ha muerto");
            currentLife = 0.0f;
        }

        sliderController.UpdateSlider(currentLife); // llama a la funcion del otro script
    }
       

}
