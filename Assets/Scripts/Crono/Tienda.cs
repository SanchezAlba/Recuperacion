using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tienda : MonoBehaviour
{
    public TextMeshProUGUI labelSaldo;
    public GameObject obejeto1;
    public GameObject objeto2;
    public TextMeshProUGUI labelPrecio;

    public GameObject comprar;
    public GameObject noComprar;

    public int saldo=4;
    public int precio1=3;
    public int precio2=5;

    // Start is called before the first frame update
    void Start()
    {
        comprar.SetActive(false);
        noComprar.SetActive(false);

        labelSaldo.text = saldo.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Objeto1()
    {
        labelPrecio.text = precio1.ToString();
        if (precio1 <= saldo)
        {
            comprar.SetActive(true);
        }

        else
        {
            noComprar.SetActive(true);
        }
    }

    public void Objeto2()
    {
        labelPrecio.text = precio2.ToString();
        if(precio2> saldo)
        {
            noComprar.SetActive(true);
        }

        else
        {
            comprar.SetActive(true);
        }
    }
}
