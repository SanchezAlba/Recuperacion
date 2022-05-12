using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCanvas : MonoBehaviour
{
    public static ScriptCanvas instance;

    public GameObject canva;
    void Awake()
    {
        if(ScriptCanvas.instance==null)
        {
            ScriptCanvas.instance = this;
            DontDestroyOnLoad(gameObject);
            
        }

        else
        {
            Destroy(this);
        }
    }


   
}
