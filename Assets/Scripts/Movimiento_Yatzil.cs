using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Yatzil : MonoBehaviour
{
    // Start is called before the first frame update

    
    

    public float playerSpeed;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento flechas
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(hor, 0, ver) * Time.deltaTime * playerSpeed);


    }
}


