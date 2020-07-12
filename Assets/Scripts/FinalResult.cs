using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalResult : MonoBehaviour
{
    public TextMesh text;
    
    void Start()
    {
        text = GetComponent<TextMesh>();
        if (win.iter == 1)
        {
            text.text = ("You cleared 1 iteration");
        }
        else
        {
            text.text = ("You cleared " + win.iter + " iterations");
        }
    }
}
