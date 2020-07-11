using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {
    // Start is called before the first frame update

    public static Rigidbody rb;
    public static float force = 3.0f;
    public static float fuel = 15.0f;
    private float HorizValueLastFrame;
    private float VertiValueLastFrame;
    public static Vector3 spawnpoint;
    public static bool rspawn = false;

    void Start() {
        spawnpoint = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        checkRespawn();
        if (fuel > 0) {
            if ((Input.GetAxis("Horizontal") != 0 && Mathf.Abs(Input.GetAxis("Horizontal")) >= HorizValueLastFrame) || (Input.GetAxis("Vertical") != 0 && Mathf.Abs(Input.GetAxis("Vertical")) >= VertiValueLastFrame)) {
                fuel -= Time.deltaTime;
                if (Input.GetAxis("Vertical") > 0) {
                    rb.AddForce(force * -1f, 0f, force);
                } else if (Input.GetAxis("Vertical") < 0) {
                    rb.AddForce(force, 0f, force * -1f);
                }
                if (Input.GetAxis("Horizontal") > 0) {
                    rb.AddForce(force, 0f, force);
                } else if (Input.GetAxis("Horizontal") < 0) {
                    rb.AddForce(force * -1f, 0f, force * -1f);
                }
            }
            HorizValueLastFrame = Mathf.Abs(Input.GetAxis("Horizontal"));
            VertiValueLastFrame = Mathf.Abs(Input.GetAxis("Vertical"));
        }
        if (transform.position.y < -10f || Input.GetKeyDown("r")) {
            rspawn = true;
        }
        if (Input.GetKeyDown("space") && transform.position.y < 0.6f) {
            rb.AddForce(Random.Range(-1000, 1000), Random.Range(500, 1000), Random.Range(-1000, 1000));
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
