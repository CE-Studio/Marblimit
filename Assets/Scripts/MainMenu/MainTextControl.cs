using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTextControl : MonoBehaviour
{
    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        if (ToggleMainText.mainTextVisible)
        {
            transform.position = originalPosition;
        }
        else if (!ToggleMainText.mainTextVisible)
        {
            transform.position = new Vector3(originalPosition.x, originalPosition.y - 20, originalPosition.z);
        }
    }
}
