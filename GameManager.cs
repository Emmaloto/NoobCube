using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {

    bool gameEnded = false;
    public float timeDelay = 1f;

    public GameObject completeLevelUI;
    
    // Get instance used to generate the score
    public Score gameScore;
    public TextMeshProUGUI finalScore;          // Find a way to get this frome the UI element instead of using a variable
    public TextMeshProUGUI cashEarned;
    public int cubePoints;


    private void Start()
    {
        cubePoints = PlayerPrefs.GetInt("Cube Points");
    }

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
        //Debug.Log(finalScore.text);

        completeLevelUI.SetActive(true);
        finalScore.text = gameScore.currentScore.ToString();

        //TextMeshProUGUI moneyText = completeLevelUI.GetComponentInChildren<TextMeshPro>;
        int newPoints = (int)gameScore.currentScore/20;
        cashEarned.text = newPoints.ToString();

        // Save score of current level
        PlayerPrefs.SetInt("Cube Points", cubePoints + newPoints);

    }
}
