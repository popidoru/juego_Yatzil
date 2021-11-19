using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{

    public GameObject Player;
    public Vector3 offset;

    //public Transform target;

    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {

        //Rotate the camera every frame so it keeps looking at the target 
        //transform.LookAt(target);

       


        transform.position = Player.transform.position + offset;
    }
}

