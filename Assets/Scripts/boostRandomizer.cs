using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boostRandomizer : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        transform.position = new Vector3(Random.Range(-100f, 100f), 0f, Random.Range(-100f, 100f));
        transform.Rotate(0f, Random.Range(0f, 360f), 0f);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
