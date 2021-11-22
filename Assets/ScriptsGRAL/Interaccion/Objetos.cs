using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetos : MonoBehaviour
{
    public Rigidbody miRB;
    public string miTag;
    public LayerMask miLayer;
    public KeyCode laKey;
    private BoxCollider miBC;
    private GameObject esteObjeto;
    public bool sePuedeAgarrar;
    

    // Start is called before the first frame update
    void Start()
    {

        miLayer = this.gameObject.layer;
        miTag = this.gameObject.tag;
        miRB = this.gameObject.GetComponent<Rigidbody>();
        miBC = this.gameObject.GetComponent<BoxCollider>();
        esteObjeto = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {


        if (sePuedeAgarrar == true)
        {


            if (Input.GetKeyDown("space"))
            {
                print("space key was pressed");
            }



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
    }


}
