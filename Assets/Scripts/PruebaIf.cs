using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaIf : MonoBehaviour
{
    public bool boolPrueba;

    void Start()
    {
        
    }

  
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            boolPrueba = true;
        }

        if(boolPrueba)
        {
            Debug.Log(boolPrueba);
        }
    }
}
