using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToLevel : MonoBehaviour
{
    public void GoToLevel()
    {
        SceneManager.LoadScene(sceneName:"Level");
    }

    public void OpenOptions()
    {
        MMSlideItems.menuState = "Options";
    }

    public void OpenCredits()
    {
        MMSlideItems.menuState = "Credits";
    }

    public void BackToMenu()
    {
        MMSlideItems.menuState = "Main";
    }
}
