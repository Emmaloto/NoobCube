using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpin : MonoBehaviour {

    public float normalSpeed = 100f;

    public bool spinX = true;
    public bool spinY = false;
    public bool spinZ = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(spinX)
            transform.Rotate(Vector3.up, normalSpeed * Time.deltaTime);
        if(spinY)
            transform.Rotate(Vector3.right, normalSpeed * Time.deltaTime);
        if(spinZ)
            transform.Rotate(Vector3.forward, normalSpeed * Time.deltaTime);

        
    }
}
