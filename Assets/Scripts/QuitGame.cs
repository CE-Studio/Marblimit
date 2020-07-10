using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown("left ctrl") || Input.GetKeyDown("right ctrl"))
        {
            Application.Quit();
        }
    }

    public void OnQuitButtonPress()
    {
        Application.Quit();
    }
}
