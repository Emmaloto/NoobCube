using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelComplete : MonoBehaviour {

    public bool loadCustomLevel = false;
    public int sceneIndex;

    public void LoadNextLevel()
    {
        if (loadCustomLevel) SceneManager.LoadScene(sceneIndex);
        else SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
