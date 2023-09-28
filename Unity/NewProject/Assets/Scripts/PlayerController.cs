using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f;
    [SerializeField] private float sprintSpeed = 10f;
    
    private CharacterController controller;
    private Vector3 movement;
    private bool isJumping;
    private bool isCrouching;
    void Start()
    { 
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //are we sprinting or walking
        float move;
        if (Input.GetKey(KeyCode.LeftShift) && isCrouching != true)
        {
            move = sprintSpeed;
        }
        else
        {
            move = moveSpeed;
        }
        
        //Crouch Functionality
        if (Input.GetKey(KeyCode.LeftControl))
        {
            isCrouching = true;
        }
        else
        {
            isCrouching = false;
        }
        
        if (isCrouching)
        {
            move /= 2;
            controller.height = 0f;
        }
        else
        {
            controller.height = 1f;
        }

        //movement script
        movement.x = Input.GetAxisRaw("Horizontal")* move ;
        movement.z = Input.GetAxisRaw("Vertical")* move  ;
        
        
        //gravity
        movement.y -= gravity * Time.deltaTime;
        
        
        //Jump functionality
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            isJumping = true;
            Debug.Log("isJumping");
            
        }
        if (isJumping)
        {
            movement.y = jumpForce;
            isJumping = false;
        }
        Debug.Log(movement.y);
        //final movement
        controller.Move(movement * Time.deltaTime);

       
        
        

        //rgb color script
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        } 
        else if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        
    }
}
