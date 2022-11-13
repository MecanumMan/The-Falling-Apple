using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject menu;
    public string Level1Name;

    public void Start()
    {
        optionsMenu.SetActive(false);
        menu.SetActive(true);
    }

    public void Play()
    {
        SceneManager.LoadScene(Level1Name);
    }

    public void Settings()
    {
        optionsMenu.SetActive(true);
        menu.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
