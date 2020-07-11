using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pbRandomizer : MonoBehaviour {
    // Start is called before the first frame update

    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
        rb.sleepThreshold = 0.0f;
        transform.position = new Vector3(Random.Range(-100f, 100f), 10f, Random.Range(-100f, 100f));
        transform.Rotate(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f));
    }

    // Update is called once per frame
    void Update() {
        if (transform.position.y < -10f) {
            Start();
        }
    }
}
