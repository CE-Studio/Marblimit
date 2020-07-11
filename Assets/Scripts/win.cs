using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public static bool hasWon = false;
    public GameObject boost;
    public GameObject lspin;
    public GameObject sspin;
    public GameObject lift;
    public GameObject wall;
    public GameObject pb;
    private float i = 0f;
    public static float gameTime = 120f;
    public static int iter = 0;
    public AudioSource alert;
    private bool tog = true;
    public Material test;
    public static bool hasTimedOut;


    // Start is called before the first frame update
    void Start()
    {
        gameTime = 120f;
        iter = 0;
        test.SetColor("_Color", new Color(1, 0.870f, 0, 1));
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
                GameObject ObjectNameeeeee = Instantiate(pb, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                i += Random.Range(0f, 1.0f);
            }
        }
        if (gameTime < 30f) {
            if (tog) {
                tog = false;
                alert.Play();
            }
        } else {
            tog = true;
        }
        if (gameTime < 0f) {
            hasTimedOut = true;
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.name == "PlayerBall") {
            test.SetColor("_Color", new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1));
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
                GameObject ObjectNameeeeee = Instantiate(pb, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                i += Random.Range(0f, 1.0f);
            }
        }
    }
}
