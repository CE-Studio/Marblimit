using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockMinimapCam : MonoBehaviour
{
    private Vector3 ballPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ballPos = GameObject.Find("PlayerBall").transform.position;
        transform.position = ballPos + new Vector3(0, 30, 0);
    }
}
