using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportaTexto : MonoBehaviour
{
    public TextAsset dialogos; // archivote con todos los dialogos
    public string[] lineasTexto; // array para que haya cierto num de lineas donde se escriban los dialogos


    // Start is called before the first frame update
    void Start()
    {
        if(dialogos != null) //checar si hay textfile pa que no crashee
        {

            lineasTexto = (dialogos.text.Split('\n')); //lo que va a aparecer en lineasTexto, se va a ir a dialogos, agarrar el texto, y partirlos cada enter

        }

    }

 
}
