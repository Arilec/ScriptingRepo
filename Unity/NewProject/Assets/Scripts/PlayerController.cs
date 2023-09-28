using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f;
    
    private CharacterController controller;
    private Vector3 movement;
    private bool isJumping;
    
    void Start()
    { 
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement script
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical") ;
        
        
        //gravity
        movement.y =- gravity * Time.deltaTime;
        
        //Jump functionality
        if (Input.GetButton("Jump") && controller.isGrounded)
        {
            isJumping = true;
            Debug.Log("isJumping");
            
        }
        if (isJumping)
        {
            movement.y = jumpForce;
            isJumping = false;
        }
        
        //final movement
        controller.Move(movement * moveSpeed * Time.deltaTime);

       
        
        

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
