using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPuzlePadres : MonoBehaviour
{
    private int pointsToWin; // Los puntos necesarios para ganar
    private int currentPoints; // Los puntos que se tienen actualmente

    public GameObject Pieces; // El Empty que contiene todas las PIEZAS DEL PUZLE

    void Start()
    {
        pointsToWin = Pieces.transform.childCount; // Los puntos a ganar se definen a través de la cantidad de hijos que tiene "Pieces"
    }

    
    void Update()
    {
        if (currentPoints >= pointsToWin) //Si los puntos actuales son mayores o iguales a los puntos a ganar, entonces...
        {
            transform.GetChild(0).gameObject.SetActive(true); //Se activa el hijo que tiene el script (PointsHandler)

            Debug.Log("GANAMOS");
        }
    }

    public void AddPoints()
    {
        currentPoints = currentPoints + 1; // Aumenta la cantidad de puntos que tienes cuando se llama (a través del script de "PiezaPuzlePadres

        Debug.Log("SUMA PUNTOS");
    }
}
