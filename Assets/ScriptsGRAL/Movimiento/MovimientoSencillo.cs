using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSencillo : MonoBehaviour
{

    public float velocidad;
    float vertical;
    float horizontal;
    private Animator miAnimator;
    private SpriteRenderer miSpriteRenderer;
    private Rigidbody miRigidBody;
    public static Transform posicionClave;
    

    // Start is called before the first frame update
    void Start()
    {
        miAnimator = GetComponent<Animator>();
        miSpriteRenderer = GetComponent<SpriteRenderer>();
        miRigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
       
        Vector3 m_Input = new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));

        
        miRigidBody.MovePosition(transform.position + m_Input * Time.deltaTime * velocidad);


    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {

            miAnimator.SetBool("CaminaFrente", false);



        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {

            miAnimator.SetBool("CaminaFrente", true);


        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {

            miAnimator.SetBool("Caminar", true);
            miSpriteRenderer.flipX = false;


        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {

            miAnimator.SetBool("Caminar", true);
            miSpriteRenderer.flipX = true;


        }


        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
        {

            miAnimator.SetBool("Caminar", false);


        }

        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
        {

            miAnimator.SetBool("Caminar", false);



        }

        if (Input.GetKeyDown(KeyCode.E))
        {

            miAnimator.SetTrigger("Recoger");



        }
    }


    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.layer == 6)
        {
           // print("hice colision con un punto clave");

            

                posicionClave = collision.gameObject.transform.GetChild(0);
               // print("se guardo la posicion de donde va el objeto del punto clave");

            
           

        }






    }


    private void OnCollisionExit(Collision collision)
    {

       






    }



}