using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMSlideItems : MonoBehaviour
{
    public Vector3 inactiveLocation;
    public Vector3 activeLocation;
    public static string menuState;
    public string itemType;

    void Start()
    {
        inactiveLocation = new Vector3(-1199, -84.27f, 1);
        activeLocation = new Vector3(-401, -84.27f, 1);
        menuState = "Main";
    }

    void Update()
    {
        if (menuState == "Main")
        {
            transform.position = Vector3.Lerp(transform.position, inactiveLocation, 0.7f);
        }
        else if (menuState == "Options" && (itemType == "Background" || itemType == "Options"))
        {
            transform.position = Vector3.Lerp(transform.position, activeLocation, 0.7f);
        }
        else if (menuState == "Credits" && (itemType == "Background" || itemType == "Credits"))
        {
            transform.position = Vector3.Lerp(transform.position, activeLocation, 0.7f);
        }
    }
}
