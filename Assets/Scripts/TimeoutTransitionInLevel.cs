using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeoutTransitionInLevel : MonoBehaviour
{
    private int steps;
    private int stepsMax = 50;
    private bool transitionInProgress;
    public AudioSource breaking;
    public AudioSource pulven;
    public AudioSource rules;
    public AudioSource sound;
    public AudioSource switching;

    void Start()
    {
        VolumeController.volumePitch = 1;
        breaking.pitch = 1;
        pulven.pitch = 1;
        rules.pitch = 1;
        sound.pitch = 1;
        switching.pitch = 1;
        win.hasTimedOut = false;
        transitionInProgress = false;
    }

    void FixedUpdate()
    {
        if (win.hasTimedOut && !transitionInProgress)
        {
            transform.Rotate(15f, 0f, 0f);
            transform.position += new Vector3(Random.Range(-0.5f, 0.5f), 0, 0);
            transitionInProgress = true;
        }
        if (transitionInProgress)
        {
            if (steps < stepsMax)
            {
                transform.position += new Vector3(0.0075f, -0.05f, -0.0075f);
            }
            steps++;
            VolumeController.volumePitch -= 0.005f;
            breaking.pitch = VolumeController.volumePitch;
            pulven.pitch = VolumeController.volumePitch;
            rules.pitch = VolumeController.volumePitch;
            sound.pitch = VolumeController.volumePitch;
            switching.pitch = VolumeController.volumePitch;
            if (steps > 200)
            {
                win.hasTimedOut = false;
                transitionInProgress = false;
                SceneManager.LoadScene(sceneName: "ded");
            }
        }
    }
}
