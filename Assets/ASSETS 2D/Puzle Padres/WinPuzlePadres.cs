using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WinPuzlePadres : MonoBehaviour
{
    public UnityEvent onWin;
    private int pointsToWin; // Los puntos necesarios para ganar
    public int currentPoints; // Los puntos que se tienen actualmente

    public GameObject Pieces; // El Empty que contiene todas las PIEZAS DEL PUZLE
    public PiezaPuzlePadres[] piezas;
    public bool win =true;
    void Start()
    {
        pointsToWin = Pieces.transform.childCount; // Los puntos a ganar se definen a través de la cantidad de hijos que tiene "Pieces"
        piezas = Pieces.GetComponentsInChildren<PiezaPuzlePadres>();
    }

    
    void Update()
    {
        win = true;
        foreach (var pieza in piezas)
        {
            win &= pieza.inPlace;// estamos (booleanamente hablando)multiplicando el valor de canda inplace, y ese valor será win, de modo que si todos los inplace son true win sera true, sino win sera false

        }
        if (win == true)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            onWin.Invoke();
            Debug.Log("GANAMOS");
        }
        //  true = 1, false = 0.
        // & = multiplicar
        // win &=  : el valor de win se multiplica por cada uno de los valores de pieza.
        //win = true * true = true
        //win = true * false = false
        //win = false * true;

    }
}
