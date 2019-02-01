using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {

    public GameObject levelMenu;
    public GameObject mainMenu;

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

    public void LoadShop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void ShowLevelMenu()
    {
        levelMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void HideLevelMenu()
    {
        levelMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void LoadLevelSelector()
    {
        SceneManager.LoadScene("Level_selector");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
        
    }

}
