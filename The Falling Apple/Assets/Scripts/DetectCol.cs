using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCol : MonoBehaviour
{
    public string Scene;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(Scene);
    }
}
