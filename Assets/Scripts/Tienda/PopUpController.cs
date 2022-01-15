using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopUpController : MonoBehaviour
{

    public static PopUpController instance;
    public TextMeshProUGUI label;


    // Start is called before the first frame update
    void Start()
    {
        if(PopUpController.instance==null)
        {
            PopUpController.instance = this;
            gameObject.SetActive(false);
        }
        else
        {
            Destroy(this);
        }
    }

    public void ShowPopup()
    {
        gameObject.SetActive(true);
        
    }
}
