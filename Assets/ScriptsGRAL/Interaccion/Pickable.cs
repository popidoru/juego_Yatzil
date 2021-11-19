using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//using InputController = *InserteSuClaseControladoraAqui*; 
using InputController = PlayerController;

//PICKABLE YATZIL


[Serializable]
public class SelfInfo
{
    public Transform self;
    public Rigidbody rb;
    public Transform originalParent;
    public Vector3 originalPosition;
    public Quaternion originalRotation;
    public List<ColInfo> colliders;

};

[Serializable]
public class ColInfo
{
    public Collider col;
    public bool isTrigger;
};

[Serializable]
public class DesiredButton
{
    public int left = 0;
    public int right = 1;
    public int center = 2;
};

public class Pickable : Interactable
{
    public Player player;
    public KeyCode desiredKey = KeyCode.E;

    [SerializeField]
    public SelfInfo objInfo;

    [SerializeField]
    public DesiredButton desiredButton;

    public bool picked;
    public bool canPick;

    [Serializable]
    public struct PoseOnPick
    {
        public Vector3 position;
        public Vector3 rotation;
    };
    [SerializeField]
    public PoseOnPick poseOnPick;

    public void Start()
    {
        objInfo.self = transform;
        objInfo.originalPosition = transform.position;
        objInfo.originalParent = transform.parent;


    }



        //OVERRIDES

         public override KeyCode KBKeyPressed(KeyCode pKey, InputController playerController)
    {
        player = playerController.player_info;



        if (IsPickingMe() == true) { } // preguntamos si el Player ya tiene algo en la mano
                                       // OnPickedKeyboardAction(pKey);
        else
        {

            if (pKey == desiredKey)
                PickMe();

        }

        return pKey;
    }

    //PRIVATES
    public bool IsPickingMe()
    {
        if (this.gameObject.transform.parent == null)
            return false;
        else
            return true;
    }

    public void PickMe()
    {

        if (transform.GetComponent<Rigidbody>())
        {
            Rigidbody rb = transform.GetComponent<Rigidbody>();
            rb.isKinematic = true;
            transform.GetComponent<Rigidbody>().useGravity = false; // apagmos la gravedad del objeto para poder moverlo
        }


        foreach (Collider col in transform.GetComponentsInChildren<Collider>())
        {
            col.isTrigger = true;
        }

        
        transform.parent = GameObject.Find("Canvas/Inventario").transform; 
        transform.localPosition = poseOnPick.position;
        

        picked = true;
    }

     
    public virtual void OnPickedKeyboardAction(KeyCode pKey)
    {

    } 


}





