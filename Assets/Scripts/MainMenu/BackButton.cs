using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite inactiveButton;
    public Sprite hoveringButton;
    public Sprite pressedButton;
    private bool pressed;
    public Animator animator;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseOver()
    {
        if (!pressed)
        {
            spriteRenderer.sprite = hoveringButton;
        }
    }

    void OnMouseExit()
    {
        spriteRenderer.sprite = inactiveButton;
    }

    void OnMouseDown()
    {
        pressed = true;
        spriteRenderer.sprite = pressedButton;
        animator.SetInteger("Menustate", 0);
    }

    void OnMouseUp()
    {
        spriteRenderer.sprite = hoveringButton;
        pressed = false;
    }
}
