using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusicController : MonoBehaviour
{
    private AudioSource musicSource;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        musicSource = GetComponent<AudioSource>();
        if (musicSource != null)
        {
            // Iniciar a reprodução da música de menu
            musicSource.Play();
        }
    }

    public void PauseMenuMusic()
    {
        if (musicSource != null && musicSource.isPlaying)
        {
            musicSource.Pause();
        }
    }

    public void StopMenuMusic()
    {
        if (musicSource != null && musicSource.isPlaying)
        {
            musicSource.Stop();
        }
    }
}

