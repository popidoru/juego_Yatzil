using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntosClave : MonoBehaviour
{

    // TODOS LOS PUNTOS CLAVE LLEVAN ESTE SCRIPT

    private Transform miPunto;
    private string miTag;
    public bool volverAgarrar;


    //Variables Puzzle Cocina
    public GameObject Maiz;
    public GameObject MaizSinHoja;
    public GameObject Masa;
    public GameObject Tortilla;
    public GameObject PuertaPapas;

    // Start is called before the first frame update
    public string GetTag()
    {
        return miTag;
    }
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

        /* if (other.tag != "Player")
          {

              other.GetComponent<Objetos>().sePuedePoner = false;

          } */


        if (other.gameObject.tag == "Foto1" && miTag == "punto1")  // Si la tag de mi objeto es correcta, y estoy en cierto punto clave...
        {
            print("tengo a mi paquete");
            volverAgarrar = false;
         //   other.transform.localScale *= 0.3f;
            other.GetComponent<BoxCollider>().enabled = false;

        }
        else
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
         //   other.transform.localScale *= 0.3f;
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

        if (other.gameObject.tag == "Foto3" && miTag == "punto3")  // Si la tag de mi objeto es correcta, y estoy en cierto punto clave...
        {

            volverAgarrar = false;
         //   other.transform.localScale *= 0.3f;
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

        if (other.gameObject.tag == "Foto4" && miTag == "punto4")  // Si la tag de mi objeto es correcta, y estoy en cierto punto clave...
        {

            volverAgarrar = false;
           // other.transform.localScale *= 0.3f;
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

        if (other.gameObject.tag == "muneca1" && miTag == "puntoM1")  // Si la tag de mi objeto es correcta, y estoy en cierto punto clave...
        {
            print("tengo a mi paquete");
            volverAgarrar = false;
            other.GetComponent<BoxCollider>().enabled = false;

        }
        else
        {
            print(other.tag);

            if (other.tag == "Player")
            {
                //  print("vete aaaaa");
                // print("holi ya se quien eres");
                volverAgarrar = true;

            }


        }



        //-----------------------------------------------------------------------PUZZLE COCINA-----------------------------------------------------------------------------------

        //Dejar Maiz en olla

        if (other.gameObject.tag == "Maiz" && miTag == "PuntoOlla")  // Si la tag de mi objeto es correcta, y estoy en cierto punto clave...
        {


            volverAgarrar = false;
            other.GetComponent<BoxCollider>().enabled = false;
            //print("tengo a mi paquete");


            Destroy(Maiz, 3);

            MaizSinHoja.transform.position = new Vector3(133.11f, 8.79f, -195.48f);





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

        if (other.gameObject.tag == "MaizSinHoja" && miTag == "PuntoMolino")  // Si la tag de mi objeto es correcta, y estoy en cierto punto clave...
        {


            volverAgarrar = false;
            other.GetComponent<BoxCollider>().enabled = false;
            //print("tengo a mi paquete");


            Destroy(MaizSinHoja, 3);

            Masa.transform.position = new Vector3(155.67f, 8.81f, -197.49f);





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

        //Dejar masa en el plato

        if (other.gameObject.tag == "Masa" && miTag == "PuntoPlato")  // Si la tag de mi objeto es correcta, y estoy en cierto punto clave...
        {


            volverAgarrar = false;
            other.GetComponent<BoxCollider>().enabled = false;
            //print("tengo a mi paquete");


            Destroy(Masa);

            Tortilla.transform.position = new Vector3(157.24f, 5.97f, -209.01f);


            PuertaPapas.SetActive(false);


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
