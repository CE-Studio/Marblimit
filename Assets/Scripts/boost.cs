using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boost : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnTriggerStay(Collider other) {
        if (other.name == "PlayerBall") {
            playerMove.rb.AddForce(500f, 0f, 0f);
        }
    }
}
