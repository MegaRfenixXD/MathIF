using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    Vector3 Direcao = Vector3.zero;
    
    CharacterController Controller;

    private Rigidbody hitbox;
    
    void Start()
    {
        hitbox = GetComponent<Rigidbody>();
        Controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       


        if (Controller.isGrounded)
        {
            Direcao = new Vector3(Input.GetAxis("Horizontal") * 0.08f, Input.GetAxis("Jump") * 0.2f, Input.GetAxis("Vertical") * 0.09f);
            Direcao = transform.TransformDirection(Direcao);




        }
        Direcao.y -= 0.6f * Time.deltaTime;
        Controller.Move(Direcao);




    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ABISMO")
        {
            hitbox.position = new Vector3(-0.4f, 0.112f, 5.33f);
            

        }
    }


}

