using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Objetos : MonoBehaviour
{
    public Rigidbody miRB;
    public string miTag;
    public LayerMask miLayer;
    public KeyCode laKey;
    private BoxCollider miBC;
    private GameObject esteObjeto;
    public bool sePuedeAgarrar;
    public bool sePuedePoner;
    public TMP_Text textoInstruccion;
    public GameObject instruccion;
    public puntosClave keypt;
    public Vector3 miEscala;
    

    // Start is called before the first frame update
    void Start()
    {

        miLayer = this.gameObject.layer;
        miTag = this.gameObject.tag;
        miRB = this.gameObject.GetComponent<Rigidbody>();
        miBC = this.gameObject.GetComponent<BoxCollider>();
        esteObjeto = this.gameObject;
        instruccion = GameObject.Find("CanvasInventario/Instruccion");
        miEscala = this.gameObject.transform.localScale;
        laKey = KeyCode.E;



    }

  

    // Update is called once per frame
    void Update()
    {
        

        if (sePuedeAgarrar == true || keypt.volverAgarrar == true)

        {




            if (Input.GetKeyDown(laKey))
            {

                Debug.Log("Si se presiona la key");

               
                  
                    GameObject Inv = GameObject.Find("Viewport/Content");

                    esteObjeto.transform.parent = Inv.transform;
                    esteObjeto.layer = 5;
                  
                    sePuedeAgarrar = false;
                    instruccion.SetActive(false);
                    esteObjeto.transform.rotation = Quaternion.Euler(0, 0, 0);
                    esteObjeto.transform.localPosition = new Vector3(0, 0, -1);
                  


                sePuedePoner = true;

              



            }


    }



    }


    private void OnCollisionStay(Collision collision)
    {
        if (esteObjeto.transform.parent == null)
        {
            print("no tengo papa");
            sePuedeAgarrar = true;

            instruccion.SetActive(true);

            textoInstruccion = instruccion.GetComponent<TMP_Text>();

            textoInstruccion.text = "Recoger [E]";

            print(esteObjeto);


        } else
        {
           
            sePuedeAgarrar = false;

        }
            







    }


    private void OnTriggerEnter(Collider other)
    {


        keypt = other.GetComponent<puntosClave>();
        print(other);


    }



    private void OnCollisionExit(Collision collision)
    {
       

        instruccion.SetActive(false);
        sePuedeAgarrar = false;
        keypt.volverAgarrar = false;
        sePuedePoner = false;
        

    }

    public void Colocar()
    {

        if(sePuedePoner == true)
        {

            esteObjeto.transform.SetParent(MovimientoSencillo.posicionClave.transform);

            esteObjeto.layer = 3;

            esteObjeto.transform.rotation = Quaternion.Euler(0, -90, 0);

            esteObjeto.transform.localPosition = new Vector3(0, 0, 0);


            esteObjeto.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);

            sePuedePoner = false;

            print("si esta corriendo el evento");

        }

        
    }
}
