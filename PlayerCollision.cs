<<<<<<< HEAD
﻿
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    //public PlayerMovementNoMat testMovement;
    public GameManager gameManager;

    public GameObject pickupEffect;
    //public PowerUp powerUpLibrary;

    void OnCollisionEnter(Collision info) {
        //Debug.Log(info.collider.name);

        // If collision occurs
        if (info.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<AudioManager>().Play("PlayerCrash");
            //testMovement.enabled = false;
            
            FindObjectOfType<GameManager>().EndGame();
        }else if(info.collider.tag == "PowerUp")
        {
            ActivatePower(info.collider);
        }


    }

    public void ActivatePower(Collider powerUp)
    {
        Debug.Log("Power obtained for Player!");

        // Spawn Effect
        Instantiate(pickupEffect, transform.position, transform.rotation);

        // Change Player or Environment
        //Instantiate(pickupEffect, player.transform.position, player.transform.rotation);
        //powerUp.gameObject.GetComponent<PowerUp>();
        // powerUpLibrary.SetReaction(powerUp.gameObject.GetComponent<PowerUp>().IDNumber, powerUp.gameObject.GetComponent<PowerUp>().powerName);
        PowerUp power = powerUp.gameObject.GetComponent<PowerUp>();
        if (power != null)
            power.SetReaction();


        // Remove Object
        Destroy(powerUp.gameObject);
    }

}
=======
﻿
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    public GameManager gameManager;

    void OnCollisionEnter(Collision info) {
        //Debug.Log(info.collider.name);

        // If collision occurs
        if (info.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }


    }

}
>>>>>>> 141f62bd46554ab52206fb4b99fffb7aa48d87d8
