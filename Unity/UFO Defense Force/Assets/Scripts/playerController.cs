using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private CharacterController _controller;
    [SerializeField] private Vector2 movementInputs;
    public float speed = 20f;

    public Vector2 stageSize = new Vector2(40f, 12f);
    
    public Vector3 stageCenter;

    private Vector3 movement;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //creates the center for our player movement
        stageCenter = transform.position;
        _controller = GetComponent<CharacterController>();
        stageSize += new Vector2(stageCenter.x, stageCenter.z);

    }

    // Update is called once per frame
    void Update()
    {

        movementInputs.x = Input.GetAxis("Horizontal");
        movementInputs.y = Input.GetAxis("Vertical");
        movement = new Vector3(movementInputs.x, -1f, movementInputs.y);
        
        //cancels out horizontal movement if player exceeds boundaries
        if (transform.position.x >= stageSize.x/2)
        {
            movement.x -= Mathf.Abs(movement.x);
        }
        if (transform.position.x <= -stageSize.x/2)
        {
            movement.x += Mathf.Abs(movement.x);
        }
        
        //cancels out vertical movement if player exceeds boundaries
        if (transform.position.z >= stageSize.y / 2)
        {
            movement.z -= Mathf.Abs(movement.z);
        }
        if (transform.position.z <= -stageSize.y / 2)
        {
            movement.z += Mathf.Abs(movement.z);
        }


        _controller.Move(movement * speed * Time.deltaTime);

    }
}
