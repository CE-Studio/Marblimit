using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boost : MonoBehaviour {
    // Start is called before the first frame update
    private float turn = 0f;
    public static float stren = 10f;

    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        //turn = Mathf.Deg2Rad * transform.rotation.y;
        turn = transform.rotation.y;
        Debug.DrawLine(transform.position + new Vector3(0f, 0.5f, 0f), transform.position + new Vector3(Mathf.Sin(turn) * stren, 0.5f, Mathf.Cos(turn) * stren));
    }

    void OnTriggerStay(Collider other) {
        if (other.name == "PlayerBall") {
            playerMove.rb.AddForce(Mathf.Sin(turn) * stren, 0f, Mathf.Cos(turn) * stren);
        }
    }
}
