using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateText : MonoBehaviour
{
    public TextMesh text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = win.gameTime + ("\n Difficulty: ") + win.iter;
    }
}
