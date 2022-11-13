using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class options : MonoBehaviour
{
    public GameObject menu;
    public GameObject optionsMenu;
    public AudioMixer master;

    public void SetRes()
    {
        Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
    }

    public void Fullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void Volume(float volume)
    {
        master.SetFloat("volume", volume);
    }

    public void NVol(float volume)
    {
        master.SetFloat("nvol", volume);
    }

    public void Back()
    {
        menu.SetActive(true);
        optionsMenu.SetActive(false);
    }
}
