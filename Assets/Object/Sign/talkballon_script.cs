using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkballon_script : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }
    public void talkballon_Enable()
    {
        spriteRenderer.enabled = true;
    }
    public void talkballon_Disable()
    {
        spriteRenderer.enabled = false;
    }
}
