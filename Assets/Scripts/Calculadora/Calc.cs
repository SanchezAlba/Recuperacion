using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Calc : MonoBehaviour
{
 
    public TMP_InputField num1;
    public TMP_InputField num2;
    

    public TextMeshProUGUI labelResultado;

    void Start()
    {
        num1.text = "0";
        num2.text = "0";
    }

    void Update()
    {
       
        int sumandoA = int.Parse(num1.text); // TryParse(con el try no funciona, poner solo PARSE) es para cambiar de string a int, ya que en el input tenemos texto, y nosotros queremos el números que escribimos
        int sumandoB = int.Parse(num2.text);
        int result = sumandoA + sumandoB;

        labelResultado.text = result.ToString();
    }


}
