using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Cues : MonoBehaviour
{
    public AudioSource firstLine;
    public int FirstLineTime;

    private void Start()
    {
        StartCoroutine(time());
    }

    private IEnumerator time()
    {
        yield return new WaitForSeconds(FirstLineTime);
        firstLine.Play();
    }
}
