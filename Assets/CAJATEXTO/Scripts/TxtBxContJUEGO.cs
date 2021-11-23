using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class TxtBxContJUEGO : MonoBehaviour
{
    public static TextAsset dialogos; // texto que va a aparecer en la caja

    public string[] lineasTexto; // array para que haya cierto num de lineas donde se escriban los dialogos

    public GameObject cajaTexto; //donde se contiene el texto

    public TMP_Text ElTexto; //para modificar el texto de la caja OJO no es puro text por que se usa textmesh pro para que se vea bien la fuente pixeleada

    public int lineaAhora; //en que linea estamos al momento
    public int endAtLine; //en que linea deberia de cortarse

    public Animator[] barras;



    // Start is called before the first frame update
    void Start()
    {


        cajaTexto.SetActive(false);


    }


    void Update()
    {

        if (dialogos != null) //checar si hay textfile pa que no crashee
        {

            lineasTexto = (dialogos.text.Split('\n')); //lo que va a aparecer en lineasTexto, se va a ir a dialogos, agarrar el texto, y partirlos cada enter

        }


        

     

        if(lineasTexto.Length > 0)
        {

            ElTexto.text = lineasTexto[lineaAhora]; //el texto dentro del objeto de texto se va a ir llenando dependendiendo de la linea de texto actual (empieza en el 0 del array)
            endAtLine = lineasTexto.Length - 1;

        }








        if (cajaTexto.activeSelf == true) //solo si el panel/caja de texto esta activa
        {

            if (Input.GetKeyDown(KeyCode.Space)) //al presionar la tecla espacio...
            {
                lineaAhora += 1; //la int de la linea de texto se suma, busca en el array, y saca la linea!



            }

        }




       /* if (endAtLine == 0)
        {
           // endAtLine = lineasTexto.Length - 1; //para que siempre aparezcan y no se confundan con el 0 del array
            //lineaAhora = endAtLine;
        } */


        if (lineaAhora > endAtLine)
        {
           
            cajaTexto.SetActive(false);
            barras[0].GetComponent<Animator>().SetTrigger("Bajan");
           barras[1].GetComponent<Animator>().SetTrigger("Bajan");
        }

        if (cajaTexto.activeSelf == false)
        {
            lineaAhora = 0;
            endAtLine = 0;


        }






    }




}
