using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeoutTransitionInDed : MonoBehaviour
{
    void Start()
    {
        transform.position += new Vector3(0, 0, Random.Range(-0.25f, 0.25f));
    }

    void Update()
    {
        transform.position += new Vector3(0, -0.05f, 0);
    }
}
