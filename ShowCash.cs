using UnityEngine;
using TMPro;

public class ShowCash : MonoBehaviour {

    public int cubePoints;
    public TextMeshProUGUI scoreUI;

    // Use this for initialization
    void Start () {
        cubePoints = PlayerPrefs.GetInt("Cube Points");
        scoreUI.text = cubePoints.ToString();
    }
	
	public void UpdateCash () {
        
    }
}
