//using System;
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;

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

    private GameObject[] _inventory;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //creates the center for our player movement
        stageCenter = transform.position;
        _controller = GetComponent<CharacterController>();
        stageSize += new Vector2(stageCenter.x, stageCenter.z);
        _inventory = new GameObject[12];

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
        //detects whether an item is for inventory
        if (other.gameObject.CompareTag("PickUp"))
        {
            for (int i = 0; i < _inventory.Length; i++)
            {
                if (_inventory[i] == null)
                {
                    _inventory[i] = other.gameObject;
                    break;
                }
            }

            foreach (var item in _inventory)
            {
                if (item != null)
                    Debug.Log(item.name);
            }
        }
        Destroy(other.gameObject);
    }
}
