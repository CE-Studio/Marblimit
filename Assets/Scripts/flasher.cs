using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flasher : MonoBehaviour
{
    //public Animation anim;
    private bool tog = true;
    public Animator anim;
    public AudioSource alert;

    // Start is called before the first frame update
    void Start()
    {
        //anim = gameObject.GetComponent<Animation>();
        //print(anim.GetClipCount());
        //foreach (AnimationState state in anim) {
        //    state.speed = 1F;
        //}
        //anim.Play("MovementGaugeStatic");
        anim.SetBool("OutOfJuice", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMove.fuel < 3f) {
            if (tog) {
                tog = false;
                alert.Play();
            //    anim.Play("MovementGaugeFlashing");
            //    print("hjhjhj");
            }
            anim.SetBool("OutOfJuice", true);
        } else {
            if (!tog) {
                tog = true;
            //    anim.Play("MovementGaugeStatic");
            }
            anim.SetBool("OutOfJuice", false);
        }
    }
}
