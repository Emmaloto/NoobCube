using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text score;
    public int currentScore;
    public float orgPos = 0.0f;

    void Start()
    {
        orgPos = player.position.z;
    }

    // Update is called once per frame
    void Update () {

        currentScore = (int)(player.position.z - orgPos);
        score.text = (player.position.z - orgPos).ToString("0");
	}

    public int getFinalScore()
    {
        //PlayerPrefs.SetInt("HighScore", currentScore);
        return currentScore;
    }
}
