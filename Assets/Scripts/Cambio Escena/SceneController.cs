using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    [SerializeField] private string sigEscena;


    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(sigEscena);
        }*/
        CambioEscena(1);
    }


    public void CambioEscena(int indice)
    {

        if (Input.GetKeyDown(KeyCode.Space)) SceneManager.LoadScene(indice);

    }
}
