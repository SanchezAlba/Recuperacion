using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  System.Security.Cryptography;

public class QuestionPopUP : MonoBehaviour
{
    public static QuestionPopUP instance;
    public GameObject containerPopUp;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            LeanTween.scale(containerPopUp, new Vector3(0f, 0f, 0f), 0.0f);
            gameObject.SetActive(false);
        }

        else
        {
            Destroy(this);
        }
    }

    public void ShowPopUp()
    {
        
        gameObject.SetActive(true);
        LeanTween.scale(containerPopUp, new Vector3(1.0f, 1.0f, 1.0f), 0.5f).setEaseOutBounce();
    }

}
