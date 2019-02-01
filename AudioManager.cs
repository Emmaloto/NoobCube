using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class AudioManager : MonoBehaviour {

    public static AudioManager instance;
    public Sound[] sounds;

    // Use this for initialization
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //Start();
        }
        else
        {
            Destroy(gameObject);
            return;

        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
	}

    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;

        if (SceneManager.GetActiveScene().buildIndex == 5 || SceneManager.GetActiveScene().buildIndex == 6)
            Play("ForestTheme");
        else if (SceneManager.GetActiveScene().buildIndex > 0 && SceneManager.GetActiveScene().buildIndex < 4) // Default 1,2,3
            Play("BeginTheme");
        else Play("MenuTheme");
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.soundName == name);
        if (s == null) {
            Debug.LogWarning("Sound " + name + " does not exist!");
            return;
        }
            

        s.source.Play();
    }

    
 public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // This needs to be called when a new scene is loaded to reset the sounds and choose the right one
        foreach (Sound s in sounds)
        {
            if (s.source.isPlaying) s.source.Stop();
        }

        Start();
    }
}
