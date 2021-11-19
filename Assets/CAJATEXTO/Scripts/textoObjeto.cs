using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class textoObjeto : MonoBehaviour
{
    public TextAsset texto;
    public GameObject cajaTexto;

    // Start is called before the first frame update
    void Start()
    {
        cajaTexto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        cajaTexto.SetActive(true);
        TxtBxContJUEGO.dialogos = texto;
    }
}
