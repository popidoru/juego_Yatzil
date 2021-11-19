using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public virtual int MouseButtonPressed(int button, PlayerController player)
    {
        return button;
    }

    public virtual KeyCode KBKeyPressed(KeyCode pKey, PlayerController player)
    {
        return pKey;
    }
}
