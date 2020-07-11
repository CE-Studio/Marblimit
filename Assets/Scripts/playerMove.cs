using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {
    // Start is called before the first frame update

    public Rigidbody rb;
    public static float force = 3.0f;
    public static float fuel = 15.0f;
    private float HorizValueLastFrame;
    private float VertiValueLastFrame;
    public static Vector3 spawnpoint;
    public bool rspawn = false;

    void Start() {
        spawnpoint = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate() {
        checkRespawn();
        if (fuel > 0) {
            rb.AddForce(Input.GetAxis("Horizontal") * force, 0f, Input.GetAxis("Vertical") * force);
            if ((Input.GetAxis("Horizontal") != 0 && Mathf.Abs(Input.GetAxis("Horizontal")) >= HorizValueLastFrame) || (Input.GetAxis("Vertical") != 0 && Mathf.Abs(Input.GetAxis("Vertical")) >= VertiValueLastFrame)) {
                fuel -= Time.deltaTime;
            }
            HorizValueLastFrame = Mathf.Abs(Input.GetAxis("Horizontal"));
            VertiValueLastFrame = Mathf.Abs(Input.GetAxis("Vertical"));
        }
        if (transform.position.y < -100f) {
            rspawn = true;
        }
    }

    void checkRespawn() {
        if (rspawn) {
            transform.position = spawnpoint;
            rspawn = false;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            fuel = 15f;
        }
    }
}
