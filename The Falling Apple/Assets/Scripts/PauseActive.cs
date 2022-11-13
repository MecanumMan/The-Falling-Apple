using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseActive : MonoBehaviour
{
    public GameObject pauseMenuPrefab;

    private void Start()
    {
        pauseMenuPrefab.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenuPrefab.SetActive(true);
        }

    }

    public void Resume()
    {
        pauseMenuPrefab.SetActive(false);
    }
}
