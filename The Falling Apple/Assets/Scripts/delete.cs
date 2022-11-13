using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class delete : MonoBehaviour
{
    public Text AreYouSure;
    public AudioSource endline;
    public AudioSource loseline;
    public int winlinetime;
    public int loselinetime;

    public void kill()
    {
        AreYouSure.text = "Are You Sure? Y/N";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log("Delete");
            endline.Play();
            SceneManager.LoadScene("Win");

        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("No Delete");
            loseline.Play();
            SceneManager.LoadScene("Level1");
        }
    }
}
