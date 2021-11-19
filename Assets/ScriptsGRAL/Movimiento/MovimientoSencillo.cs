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

    // Start is called before the first frame update
    void Start()
    {
        miAnimator = GetComponent<Animator>();
        miSpriteRenderer = GetComponent<SpriteRenderer>();
        miRigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        vertical = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;
        horizontal = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;

        transform.Translate(horizontal, 0, 0);
        transform.Translate(0, 0, vertical);



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



    }


}