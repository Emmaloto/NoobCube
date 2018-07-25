
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
