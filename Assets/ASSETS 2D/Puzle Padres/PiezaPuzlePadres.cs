using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PiezaPuzlePadres : MonoBehaviour
{
    private Vector3 correctPosition; //La posición CORRECTA de la pieza de puzle
    public bool inPlace; // La pieza está en su lugar


    void Start()
    {
        correctPosition = transform.position; //La POSICIÓN CORRECTA es de acuerdo a la posición actual de la pieza del puzzle
        transform.position = new Vector3(Random.Range(5f, 10f), Random.Range(3f, 10f)); //Cuando inicia el juego, pone las piezas de forma random, para que el jugador encuentre la posición correcta
    }

    
    void Update()
    {
        if (Vector3.Distance(transform.position,correctPosition) < 0.8f)  //Si la posición que da el jugador se acerca a la POSICIÓN CORRECTA, entonces.. 
        {
            transform.position = correctPosition;  // La posición actual se convierte en la POSICIÓN CORRECTA
            inPlace = true; //El LUGAR CORRECTO SE ACTIVA
           // GetComponent<SortingGroup>().sortingOrder = 0;  //Se regresa el ORDEN DE LAYER al default

            //GameObject.Find("PointsHandler").GetComponent<WinPuzlePadres>().AddPoints(); //Llama a la acción AddPoints que se encuentra en el script de WinPuzlePadres
            
        }


    }
}
