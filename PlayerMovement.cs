using System.Collections;
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
