using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public Scene scene;
    private string sceneName;
    public static int volume = 5;
    public AudioSource morph;
    public AudioSource breaking;
    public AudioSource pulven;
    public AudioSource rules;
    public AudioSource sound;
    public AudioSource switching;
    public Text volumeValue;

    void Start()
    {
        volumeValue = GetComponent<Text>();
    }

    void Update()
    {
        scene = SceneManager.GetActiveScene();
        sceneName = scene.name;
        if (sceneName == "Titlescreen")
        {
            breaking.volume = volume / 10;
            volumeValue.text = ("" + volume);
        }
        else if (sceneName == "Level")
        {
            morph.volume = volume / 10;
            pulven.volume = volume / 10;
            rules.volume = volume / 10;
            sound.volume = volume / 10;
            switching.volume = volume / 10;
        }
    }
}
