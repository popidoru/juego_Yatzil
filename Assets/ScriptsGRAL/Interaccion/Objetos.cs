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
    public static bool sePuedePoner;
    private TMP_Text textoInstruccion;
    public GameObject instruccion;
    

    // Start is called before the first frame update
    void Start()
    {

        miLayer = this.gameObject.layer;
        miTag = this.gameObject.tag;
        miRB = this.gameObject.GetComponent<Rigidbody>();
        miBC = this.gameObject.GetComponent<BoxCollider>();
        esteObjeto = this.gameObject;
        sePuedeAgarrar = false;

        instruccion = GameObject.Find("Canvas/Instruccion");

      



    }

    // Update is called once per frame
    void Update()
    {
        

        if (sePuedeAgarrar == true)
        {


            



            if (Input.GetKeyDown(laKey))
            {

                Debug.Log("Si se presiona la key");

                if (esteObjeto.transform.parent == null)
                {

                  
                    GameObject Inv = GameObject.Find("Viewport/Content");

                    esteObjeto.transform.parent = Inv.transform;
                    esteObjeto.layer = 5;
                    esteObjeto.AddComponent<RectTransform>();
                    sePuedeAgarrar = false;
                    instruccion.SetActive(false);
                    esteObjeto.transform.rotation = Quaternion.Euler(0, 0, 0);
                    esteObjeto.transform.localPosition = new Vector3(0, 0, -1);
                    sePuedePoner = true;

                } else
                {

                  /*  if (esteObjeto.transform.parent.tag == "PuntosClave")
                    {

                        sePuedeAgarrar = true;
                        instruccion.SetActive(true);
                        textoInstruccion = instruccion.GetComponent<TMP_Text>();

                        textoInstruccion.text = "Recoger [E]";


                    } */

                }
               



            }


    }



    }


    private void OnCollisionStay(Collision collision)
    {

        
        sePuedeAgarrar = true;

        instruccion.SetActive(true);

        textoInstruccion = instruccion.GetComponent<TMP_Text>();

        textoInstruccion.text = "Recoger [E]";

       


    }

    private void OnCollisionExit(Collision collision)
    {
       

        instruccion.SetActive(false);
        sePuedeAgarrar = false;
        sePuedePoner = false;
        

    }

    public void Colocar()
    {

        esteObjeto.transform.SetParent(MovimientoSencillo.posicionClave.transform);

        esteObjeto.layer = 3;

        sePuedeAgarrar = true;

        esteObjeto.transform.rotation = Quaternion.Euler(0, -90, 0);

        esteObjeto.transform.localPosition = new Vector3(0, 0, 0);

        sePuedePoner = false;

        print("si esta corriendo el evento");
    }
}
