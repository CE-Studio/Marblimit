using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeValueDisplay : MonoBehaviour
{
    public TextMesh value;
    
    void Start()
    {
        value = GetComponent<TextMesh>();
    }

    void Update()
    {
        value.text = ("" + VolumeController.volume);
    }
}
