using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsTextController : MonoBehaviour
{
    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        if (ToggleOptionsText.optionsTextVisible)
        {
            transform.position = originalPosition;
        }
        else if (!ToggleOptionsText.optionsTextVisible)
        {
            transform.position = new Vector3(originalPosition.x, originalPosition.y - 30, originalPosition.z);
        }
    }
}
