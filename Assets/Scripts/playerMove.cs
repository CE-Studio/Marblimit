using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {
    // Start is called before the first frame update

    public Rigidbody rb;
    public static float force = 2.0f;
    public static float fuel = 15.0f;
    private float HorizValueLastFrame;
    private float VertiValueLastFrame;

    void Start() {
        
    }

    // Update is called once per frame
    void FixedUpdate() {
        rb.AddForce(Input.GetAxis("Horizontal") * force, 0f, Input.GetAxis("Vertical") * force);
        if ((Input.GetAxis("Horizontal") != 0 && Mathf.Abs(Input.GetAxis("Horizontal")) >= HorizValueLastFrame) || (Input.GetAxis("Vertical") != 0 && Mathf.Abs(Input.GetAxis("Vertical")) >= VertiValueLastFrame)) {
            fuel -= Time.deltaTime;
        }
        HorizValueLastFrame = Mathf.Abs(Input.GetAxis("Horizontal"));
        VertiValueLastFrame = Mathf.Abs(Input.GetAxis("Vertical"));
    }
}
