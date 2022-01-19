using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UsuarioYContra : MonoBehaviour
{
    public TMP_InputField inputUsuario;
    public TMP_InputField inputContra;
    public GameObject popUp;
    public GameObject botonAceptar;

    public float timer = 0.0f;

    public bool isActive = false;

    public string contraseña = "hola";


    private void Start()
    {
        popUp.SetActive(false);
    }

    private void Update()
    {
        if (isActive==true)
        {
            timer += Time.deltaTime;

            if(timer >= 3.0f)
            {
                popUp.SetActive(false);
            }
         
        }

        
    }
    public void Comprobar()
    {
        timer = 0.0f;

        if (contraseña == inputContra.text)
        {
            Debug.Log("es correcto");
        }

        else
        {
            popUp.SetActive(true);

            isActive = true;
           
        }
    }

    public void Aceptar()
    {
        if(isActive==false)
        {
            popUp.SetActive(false);
            
            //inputContra.text = "";
            //Destroy(popUp);
        } 
    }
}
