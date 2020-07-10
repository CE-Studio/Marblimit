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
}
