<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Reference to Rigidbody component rb
    public GameManager manager;
    public Rigidbody rb;

    public LayerMask groundLayers;
    public BoxCollider col;

    public float forwardForce = 450f;
    public float sideForce = 100f;
    public float jumpForce = 10f;
    public Material defaultSkin;

    public int jumps = 1;

    private void Start()
    {
        //GetComponent<MeshRenderer>() = GameController.control.skin;
        //GameObject cube = gameObject;

        if (GameController.control != null)
        {
            if (GameController.control.skin != null)
                this.GetComponent<MeshRenderer>().material = GameController.control.skin;
            else
                this.GetComponent<MeshRenderer>().material = defaultSkin;
        }
        /*
        if (GameController.control.skin)
            this.GetComponent<MeshRenderer>().material = defaultSkin;
        else
            this.GetComponent<MeshRenderer>().material = GameController.control.skin;
            */
    }

    // Update is called once per frame (framerate varies with machine)
    void Update () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Move cube with a and d keys
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //Debug.Log("Moving right!");
        }
        else if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //Debug.Log("Moving left!");

        }
        else if (IsGrounded() && Input.GetKeyDown(KeyCode.Space) && manager.jumpsGotten > 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            manager.jumpsGotten --;

            Debug.Log("Sucessful JUMP! You now have " + manager.jumpsGotten);
        }

        if(rb.position.y < -1f) FindObjectOfType<GameManager>().EndGame();
    }

    private bool IsGrounded()
    {
        bool check = Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), 
            col.size.x/2 * .9f, groundLayers);
        return check;
    }

    // More Preferable than Update when messing consistently with Physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Reference to Rigidbody component rb
    public Rigidbody rb;

    public float forwardForce = 400f;
    public float sideForce = 500f;
	
	// Update is called once per frame (framerate varies with machine)
	void Update () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Move cube with a and d keys
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f) FindObjectOfType<GameManager>().EndGame();
    }

    // More Preferable than Update when messing consistently with Physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
>>>>>>> 141f62bd46554ab52206fb4b99fffb7aa48d87d8
