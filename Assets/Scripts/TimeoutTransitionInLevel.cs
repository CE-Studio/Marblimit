using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeoutTransitionInLevel : MonoBehaviour
{
    private int steps;
    private int stepsMax = 50;
    private bool transitionInProgress;

    void Update()
    {
        if (win.hasTimedOut && !transitionInProgress)
        {
            transform.Rotate(0f, 0f, 0f);
            transform.position = new Vector3(Random.Range(-0.5f, 0.5f), 0, 0);
            transitionInProgress = true;
        }
    }
}
