using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopItems : MonoBehaviour
{
    public TextMeshProUGUI etiquetaPrecio; //botones
    public int precio;

    // Start is called before the first frame update
    void Start()
    {
        precio = Random.Range(20, 170);
        etiquetaPrecio = GetComponentInChildren<TextMeshProUGUI>();
        etiquetaPrecio.text = precio.ToString()+"€";
    }

   public void ClickButton()
    {
        ShopController.instance.BuyItem(precio, GetComponent<Button>());
    }
}
