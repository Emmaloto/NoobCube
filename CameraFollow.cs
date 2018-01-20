
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform player;  // Link to player (box)
    public Vector3 offset;    // Offset of camera from player
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(player.position);

        transform.position = player.position + offset;
	}
}
