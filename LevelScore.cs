using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class LevelScore : MonoBehaviour {

    public Score scoreScript;
    public TextMeshProUGUI scoreUI;


	public void printScore()
    {
        scoreUI.text = scoreScript.getFinalScore().ToString();
        //GetComponent(TextMesh).text = "Hello World";

    }

}
