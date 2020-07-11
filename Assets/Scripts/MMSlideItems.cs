using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMSlideItems : MonoBehaviour
{
    public float distanceToMove;
    public string directionToMove;
    public string menuElementType;
    public Vector3 originalLocation;
    public static string menuState;

    void Start()
    {
        originalLocation = transform.position;
        menuState = "Main";
    }

    void Update()
    {
        if (menuState == "Main")
        {
            if (menuElementType == "Main")
            {
                transform.position += new Vector3((transform.position.x + originalLocation.x) / 100, 0, 0);
            }
        }
    }
}
