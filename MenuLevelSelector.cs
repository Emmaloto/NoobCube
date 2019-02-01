using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLevelSelector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void selectForest1()
    {
        SceneManager.LoadScene("Forest_Level_01");
        Debug.Log("Forest 1 Selected");
    }

    public void selectForest2()
    {
        SceneManager.LoadScene("Forest_Level_02");
        Debug.Log("Forest 2 Selected");
    }

    public void ShowMainMenu()
    {
        SceneManager.LoadScene("Welcome");
    }
}
