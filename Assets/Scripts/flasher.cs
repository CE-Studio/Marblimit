using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flasher : MonoBehaviour
{
    private Animation anim;
    private bool tog = true;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        print(anim.GetClipCount());
        foreach (AnimationState state in anim) {
            state.speed = 1F;
        }
        anim.Play("graphidle");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMove.fuel < 3f) {
            if (tog) {
                tog = false;
                anim.Play("graphflash");
                print("hjhjhj");
            }
        } else {
            if (!tog) {
                tog = true;
                anim.Play("graphidle");
            }
        }
    }
}
