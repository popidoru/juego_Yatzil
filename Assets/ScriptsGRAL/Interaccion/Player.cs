using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///
/// </summary>


// con esta instruccion obligamos al objeto a agregarse (si no lo tiene)
// una componente tipo Player_Controller
[System.Serializable]
public class Player : MonoBehaviour
{

    

    // INFO DEL PLAYER

    public Transform player;
    public Transform body;
    public Transform hand;
    public Transform objInHand;
    public Transform head; 


    // CONTROLADOR
    public PlayerController input_controller;
    
    
    private void Update()
    {
        if (hand.childCount > 0)
            objInHand = hand.GetChild(0);
        else
            objInHand = null;
    }

}