using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text score;
    public float orgPos = 0.0f;

    void Start()
    {
        orgPos = player.position.z;
    }

    // Update is called once per frame
    void Update () {
        score.text = (player.position.z - orgPos).ToString("0");
	}
}
