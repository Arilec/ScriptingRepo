using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private CharacterController _controller;
    [SerializeField] private Vector2 movementInputs;
    public float speed = 20f;
    
    public Transform cannon;

    public GameObject projectile;

    public Vector2 stageSize = new Vector2(40f, 12f);
    
    public Vector3 stageCenter;

    private Vector3 _movement;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        //creates the center for our player movement
        stageCenter = transform.position;
        _controller = GetComponent<CharacterController>();
        stageSize += new Vector2(stageCenter.x, stageCenter.z);
        cannon = GetComponentInChildren<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        //get movement inputs
        movementInputs.x = Input.GetAxis("Horizontal");
        movementInputs.y = Input.GetAxis("Vertical");
        _movement = new Vector3(movementInputs.x, -1f, movementInputs.y);
        
        //cancels out horizontal movement if player exceeds boundaries
        if (transform.position.x >= stageSize.x/2)
        {
            _movement.x -= Mathf.Abs(_movement.x);
        }
        if (transform.position.x <= -stageSize.x/2)
        {
            _movement.x += Mathf.Abs(_movement.x);
        }
        
        //cancels out vertical movement if player exceeds boundaries
        if (transform.position.z >= stageSize.y / 2)
        {
            _movement.z -= Mathf.Abs(_movement.z);
        }
        if (transform.position.z <= -stageSize.y / 2)
        {
            _movement.z += Mathf.Abs(_movement.z);
        }


        _controller.Move(_movement * speed * Time.deltaTime);
    //change for automatic fire and multi-fire
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //creates projectile at cannon
            Instantiate(projectile, cannon.position, projectile.transform.rotation);
        }

    }

    //destroys projectiles that collide with player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
