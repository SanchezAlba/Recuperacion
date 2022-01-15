using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    public TextMeshProUGUI etiquetaMoney;
    public int money;

    public static ShopController instance; // es static pq solo hay una tienda


    void Start()
    {
        money = Random.Range(50, 200);
        etiquetaMoney.text = money.ToString();

        if (ShopController.instance==null)
        {
            ShopController.instance = this;
        }

        else
        {
            Destroy(this);
        }
    }

    public void BuyItem(int itemPrice, Button buttonItem)
    {
        if(money >= itemPrice)
        {
            Debug.Log("Tiene dinero");
            money = money - itemPrice;
            etiquetaMoney.text = money.ToString() + "€";
            buttonItem.interactable = false;
        }

        else
        {
            Debug.Log("Tienes que ahorras, ¡Pobre!");
        }
    }
}
