using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class formaDos : MonoBehaviour
{
    public SpashipData myShip;
    public Transform iconParents; // nos dice cual es el hijo

    
    void Update()
    {

        for(int iconoModificado = 0; iconoModificado < iconParents.childCount; iconoModificado++)
        {
            if (myShip.speed > iconoModificado)
            {iconParents.GetChild(iconoModificado).gameObject.SetActive(true);
            }

            else 
            {
                iconParents.GetChild(iconoModificado).gameObject.SetActive(false);
            }
            
        }

       

    }
}
