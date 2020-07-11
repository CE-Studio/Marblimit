using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTextControl : MonoBehaviour
{
    private Vector3 originalposition;

    void Start()
    {
        originalposition = transform.position;
    }

    void Update()
    {
        if (ToggleMainText.mainTextVisible)
        {
            transform.position = originalposition;
        }
        else if (!ToggleMainText.mainTextVisible)
        {
            transform.position = new Vector3();
        }
    }
}
