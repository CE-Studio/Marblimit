using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMainText : MonoBehaviour
{
    public static bool mainTextVisible = true;

    void OnTriggerEnter(Collider MainCamera)
    {
        mainTextVisible = !mainTextVisible;
    }
}
