using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntosClave : MonoBehaviour
{

    // TODOS LOS PUNTOS CLAVE LLEVAN ESTE SCRIPT

    private Transform miPunto;
    private string miTag;

    // Start is called before the first frame update
    void Start()
    {

        miTag = this.gameObject.tag;

    }

    // Update is called once per frame
    void Update()
    {
        

     


    }


    private void OnCollisionEnter(Collision collision)
    {
        

        
        //Aqui escribir que tiene que pasar cuando el objeto correcto es puesto en el punto clave con un if


        if (collision.gameObject.tag == "foto1" && miTag == "punto1")  // Si la tag de mi objeto es correcta, y estoy en cierto punto clave...
        {
            //pasa esto




        }


    }



}
