using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    protected int pMB;
    protected KeyCode pKB;
    public Player player_info;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Interactable>()) // si el objeto con el que chocó tiene un Interactable
            Action(pMB, pKB, other.GetComponent<Interactable>());
    }

    protected void Action(int pmb, KeyCode kmb, Interactable script)
    {
        script.MouseButtonPressed(pmb, this);
        script.KBKeyPressed(kmb, this);
    }

    protected void test()
    {
        pMB = MouseCheck();
        pKB = KeyBoardCheck();
    }

    protected int MouseCheck() // checar y devolver el boton que se ha presionado del mouse
    {
        if (Input.GetMouseButton(0)) //
            return 0;

        else if (Input.GetMouseButton(1)) //
            return 1;
        else if (Input.GetMouseButton(2))
            return 2;
        else
            return -1;
    }

    private KeyCode[] desiredKeys = { KeyCode.E, KeyCode.Space, KeyCode.Q, KeyCode.Return, KeyCode.Alpha2, KeyCode.R, KeyCode.G, KeyCode.B };
    KeyCode KeyBoardCheck()
    {
        foreach (KeyCode keyToCheck in desiredKeys) // para todos los elementos en desiredKeys
        {
            if (Input.GetKey(keyToCheck)) // preguntar si se presionó cada tecla
                return keyToCheck; // si si, devolver esa tecla
        }
        return 0;
    }

}
