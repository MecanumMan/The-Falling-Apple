using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public GameObject pauseMenuPrefab;
    public AudioMixer master;
    public string StartScreen;

    public void Volume(float volume)
    {
        master.SetFloat("volume", volume);
    }

    public void NVol(float volume)
    {
        master.SetFloat("nvol", volume);
    }

    public void ExitToMainMenu()
    {
        SceneManager.LoadScene(StartScreen);
    }

    public void ExitToDesktop()
    {
        Application.Quit();
    }
}
