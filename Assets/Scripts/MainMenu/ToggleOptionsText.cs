using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOptionsText : MonoBehaviour
{
    public static bool optionsTextVisible = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            optionsTextVisible = !optionsTextVisible;
        }
    }
}
