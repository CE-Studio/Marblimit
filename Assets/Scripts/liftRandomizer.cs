using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liftRandomizer : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        transform.position = new Vector3(Random.Range(-100f, 100f), -1f, Random.Range(-100f, 100f));
        transform.Rotate(0f, Random.Range(0f, 360f), 0f);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
