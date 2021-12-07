using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PiezaPuzlePadres : MonoBehaviour
{
    private Vector3 correctPosition; //La posici�n CORRECTA de la pieza de puzle
    public bool inPlace; // La pieza est� en su lugar


    void Start()
    {
        correctPosition = transform.position; //La POSICI�N CORRECTA es de acuerdo a la posici�n actual de la pieza del puzzle
        transform.position = new Vector3(Random.Range(5f, 10f), Random.Range(3f, 10f)); //Cuando inicia el juego, pone las piezas de forma random, para que el jugador encuentre la posici�n correcta
    }

    
    void Update()
    {
        if (Vector3.Distance(transform.position,correctPosition) < 0.8f)  //Si la posici�n que da el jugador se acerca a la POSICI�N CORRECTA, entonces.. 
        {
            transform.position = correctPosition;  // La posici�n actual se convierte en la POSICI�N CORRECTA
            inPlace = true; //El LUGAR CORRECTO SE ACTIVA
           // GetComponent<SortingGroup>().sortingOrder = 0;  //Se regresa el ORDEN DE LAYER al default

            //GameObject.Find("PointsHandler").GetComponent<WinPuzlePadres>().AddPoints(); //Llama a la acci�n AddPoints que se encuentra en el script de WinPuzlePadres
            
        }


    }
}
