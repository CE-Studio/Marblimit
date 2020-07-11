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
    public static float gameTime = 120f;
    public static int iter = 0;


    // Start is called before the first frame update
    void Start()
    {
        gameTime = 120f;
        iter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        gameTime -= Time.deltaTime;
        if (Input.GetKeyDown("backspace")) {
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

    void OnTriggerEnter(Collider other) {
        if (other.name == "PlayerBall") {
            hasWon = true;
            gameTime = 120f;
            playerMove.rspawn = true;
            i = 0f;
            iter += 1;
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
