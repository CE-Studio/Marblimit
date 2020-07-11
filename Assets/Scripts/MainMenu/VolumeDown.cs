using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeDown : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite inactiveButton;
    public Sprite hoveringButton;
    public Sprite pressedButton;
    private bool pressed;

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
        if (VolumeController.volume > 0)
        {
            VolumeController.volume--;
        }
    }

    void OnMouseUp()
    {
        spriteRenderer.sprite = hoveringButton;
        pressed = false;
    }
}
