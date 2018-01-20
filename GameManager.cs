using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

    bool gameEnded = false;
    public float timeDelay = 1f;

    public GameObject completeLevelUI;

    public void EndGame()
    {
        // Gets game over to display only once
        if (!gameEnded)
        {
            Debug.Log("Game Over");
            gameEnded = true;
            Invoke("Restart", timeDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        //Debug.Log("Level 1 Complete");

        completeLevelUI.SetActive(true);
    }
}
