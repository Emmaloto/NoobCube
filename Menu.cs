using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {



	public void StartGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene("Level_01_BoxGame");
    }

    public void ShowInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void ShowMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Welcome");
    }



    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
        
    }

}
