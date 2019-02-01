<<<<<<< HEAD
﻿using UnityEngine.SceneManagement;
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
=======
﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelComplete : MonoBehaviour {

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
>>>>>>> 141f62bd46554ab52206fb4b99fffb7aa48d87d8
