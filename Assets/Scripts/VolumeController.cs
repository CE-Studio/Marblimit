using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public static float volume = 5;
    public AudioSource breaking;
    public AudioSource morph;
    public AudioSource pulven;
    public AudioSource rules;
    public AudioSource sound;
    public AudioSource switching;

    void Update()
    {
        breaking.volume = volume / 10;
        morph.volume = volume / 10;
        pulven.volume = volume / 10;
        rules.volume = volume / 10;
        sound.volume = volume / 10;
        switching.volume = volume / 10;
    }
}
