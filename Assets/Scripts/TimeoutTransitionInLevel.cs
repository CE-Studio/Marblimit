using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeoutTransitionInLevel : MonoBehaviour
{
    private int steps;
    private int stepsMax = 25;
    private bool transitionInProgress;

    void Update()
    {
        if (win.hasTimedOut && !transitionInProgress)
        {
            transform.Rotate(15f, -45f, 0f);
            transform.position += new Vector3(Random.Range(-0.5f, 0.5f), 0, 0);
            transitionInProgress = true;
        }
        if (transitionInProgress)
        {
            if (steps < stepsMax)
            {
                transform.position += new Vector3(0.025f, -0.1f, -0.025f);
            }
            steps++;
            if (steps > 100)
            {
                SceneManager.LoadScene(sceneName: "ded");
            }
        }
    }
}
