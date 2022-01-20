using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Record : MonoBehaviour
{
    TMP_InputField inputname;
       public TextMeshProUGUI labelText;

    // Start is called before the first frame update
    void Sawake()
    {
       labelText.text = PlayerPrefs.GetString("Nombre guardado","No hay reords"); //la etiqueta que le damos. , tras la coma el el valor que le damos
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickButton«()
    {
        //inputname.text

            PlayerPrefs.SetString("nombreGuardado", inputname.text); //entcomillas, el fichero creado arriba, lo otro lo que queremos guardar
    }

}
