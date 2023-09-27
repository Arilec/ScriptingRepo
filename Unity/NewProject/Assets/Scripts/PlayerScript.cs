using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movement script
        float forward = Input.GetAxisRaw("Horizontal");
        float right = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(forward, 0, right);

        GetComponent<CharacterController>().Move(movement * Time.deltaTime);
        
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
