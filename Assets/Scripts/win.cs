using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    public static bool hasWon = false;
    public GameObject boost;
    public GameObject lspin;
    public GameObject sspin;
    public GameObject lift;
    public GameObject wall;
    private float i = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.name == "PlayerBall") {
            hasWon = true;
            playerMove.rspawn = true;
            i = 0f;
            while (i < 5) {
                GameObject ObjectName = Instantiate(boost, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                GameObject ObjectNamee = Instantiate(lspin, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                GameObject ObjectNameee = Instantiate(sspin, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                GameObject ObjectNameeee = Instantiate(lift, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                GameObject ObjectNameeeee = Instantiate(wall, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                i += Random.Range(0f, 1.0f);
            }
        }
    }
}
