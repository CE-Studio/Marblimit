using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMove.fuel > 0) {
            transform.localScale = new Vector3(playerMove.fuel * 0.41333f, 1, 1);
        }
    }
}
