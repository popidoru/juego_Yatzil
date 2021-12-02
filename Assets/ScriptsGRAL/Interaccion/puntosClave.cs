using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntosClave : MonoBehaviour
{

    // TODOS LOS PUNTOS CLAVE LLEVAN ESTE SCRIPT

    private Transform miPunto;
    private string miTag;
    public bool volverAgarrar;

    // Start is called before the first frame update
    void Start()
    {

        miTag = this.gameObject.tag;
        volverAgarrar = false;
    }

    // Update is called once per frame
    void Update()
    {
        

     


    }


    private void OnTriggerEnter(Collider other)
    {

       if (other.tag != "Player")
        {

            other.GetComponent<Objetos>().sePuedePoner = false;

        }


        if (other.gameObject.tag == "Foto1" && miTag == "punto1")  // Si la tag de mi objeto es correcta, y estoy en cierto punto clave...
        {
            print("tengo a mi paquete");
            volverAgarrar = false;
            other.GetComponent<BoxCollider>().enabled = false;

        } else
        {
            print(other.tag);

            if (other.tag == "Player")
            {
              //  print("vete aaaaa");
                // print("holi ya se quien eres");
                volverAgarrar = true;

            }
           
            
        }


        if (other.gameObject.tag == "Foto2" && miTag == "punto2")  // Si la tag de mi objeto es correcta, y estoy en cierto punto clave...
        {
            
            volverAgarrar = false;
            other.GetComponent<BoxCollider>().enabled = false;
            print("tengo a mi paquete");

        }
        else
        {
            if (other.tag == "Player")
            {
                print("vete aaaaa");
              //  print("holi ya se quien eres");
                volverAgarrar = true;

            }


        }


    }





}
