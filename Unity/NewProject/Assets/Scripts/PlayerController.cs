//using System;
//using System.Collections;
//using System.Collections.Generic;

using System;
using UnityEngine;
//using UnityEngine.InputSystem;
//using UnityEngine.UIElements;
//using Cursor = UnityEngine.UIElements.Cursor;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f;
    [SerializeField] private float sprintSpeed = 10f;
    [SerializeField] private float mouseSens = 3f;
    //[SerializeField]private Camera camera;
    
    private CharacterController controller;
    private Vector3 movement;
    private Vector2 mouseLook;
    private bool isJumping;
    private bool isCrouching;
   
    [SerializeField] private Transform childTrans;
    [SerializeField] private Rigidbody childRB;
    
    
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        //Mouse as inputs
        mouseLook.y += Input.GetAxis("Mouse X") * mouseSens;
        mouseLook.x -= Input.GetAxis("Mouse Y") * mouseSens;
        
        
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

        //movement input
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

        transform.rotation = Quaternion.Euler(0f, mouseLook.y, 0f);
        childTrans.rotation = Quaternion.Euler(mouseLook);
        
        
        //final movement
        controller.Move(movement * Time.deltaTime);

        
        //Combat Roll
        if (Input.GetKeyDown(KeyCode.R))
        {
            //want to do switch statement, but because of user stuff I can't
            controller.height = 0f;
            controller.Move(movement * move * Time.deltaTime);
        }
        
        
        
        

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
