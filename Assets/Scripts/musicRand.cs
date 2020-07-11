using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicRand : MonoBehaviour {
    // Start is called before the first frame update

    public AudioSource a0;
    public AudioSource a1;
    public AudioSource a2;
    public AudioSource a3;
    public AudioSource a4;

    void Start() {
        switch ((int)Mathf.Round(Random.Range(0, 4))) {
            case 0:
                a0.Play();
                break;
            case 1:
                a1.Play();
                break;
            case 2:
                a2.Play();
                break;
            case 3:
                a3.Play();
                break;
            case 4:
                a4.Play();
                break;
        }
    }

    // Update is called once per frame
    void Update() {
        if (!(a0.isPlaying || a1.isPlaying || a2.isPlaying || a3.isPlaying || a4.isPlaying)) {
            Start();
        }
    }
}
