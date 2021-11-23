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
    public TMP_Text textoInstruccion;
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

                  
                    GameObject Inv = GameObject.Find("Canvas/Inventario");

                    esteObjeto.transform.parent = Inv.transform;
                    esteObjeto.layer = 5;
                    esteObjeto.AddComponent<RectTransform>();
                    sePuedeAgarrar = false;
                    instruccion.SetActive(false);

                }
                else

                {

                    //aqui va usar el game object del inventario en un punto clave o inspeccionarlo, pero no se puede sacar si no estas en un punto clave, presionar la key tendria que no hacer nada

                }



            }


    }



    }


    private void OnCollisionStay(Collision collision)
    {
        sePuedeAgarrar = true;

        instruccion.SetActive(true);

        textoInstruccion.text = "Recoger [E]";

    }

    private void OnCollisionExit(Collision collision)
    {
       

        instruccion.SetActive(false);
        sePuedeAgarrar = false;

        

    }

    private void Colocar()
    {


        // adopte la posicion indicada en el box collider del punto clave

    }
}
