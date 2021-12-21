using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calculadora : MonoBehaviour
{
    public TextMeshProUGUI labelNum1;
    public TextMeshProUGUI labelNum2;
    public TextMeshProUGUI labelResultado;

    public int num1 = 0;
    public int num2 = 0;
    public int resultado = 0;

    void Start()
    {
        labelNum1.text = num1.ToString();
        labelNum2.text = num2.ToString();
        labelResultado.text = resultado.ToString();
    }

    
    void Update()
    {
        
    }
}
