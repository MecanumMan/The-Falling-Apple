using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showmenu : MonoBehaviour
{
    public GameObject menu;

    private void Start()
    {
        menu.SetActive(false);
        wait();
    }

    private IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
        menu.SetActive(true);
    }
}
