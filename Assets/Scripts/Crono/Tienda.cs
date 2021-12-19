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
        labelSaldo.text = saldo.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Objeto1()
    {
        labelPrecio.text = precio1.ToString();
    }

    public void Objeto2()
    {
        labelPrecio.text = precio2.ToString();
    }

    public void Comprar()
    {
      if(precio1 <= saldo)
        {
            comprar.SetActive(true);
        }
      else
        {
            comprar.SetActive(false);
            noComprar.SetActive(true);
        }
    }
}
