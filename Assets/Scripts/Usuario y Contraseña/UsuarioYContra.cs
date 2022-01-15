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

    string contraseña = "hola";


    private void Start()
    {
        popUp.SetActive(false);
    }

    private void Update()
    {
        
    }
    public void Comprobar()
    {
        if (contraseña == inputContra.text)
        {
            Debug.Log("es correcto");
        }

        else
        {
            popUp.SetActive(true);
           
        }
    }

    public void Aceptar()
    {
        popUp.SetActive(false);
        
        
    }
   
}
