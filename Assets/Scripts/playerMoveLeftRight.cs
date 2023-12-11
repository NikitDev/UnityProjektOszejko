using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoveLeftRight : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Rotate(-1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Rotate(1);
        }
    }

    void Rotate(int direction)
    {
        if (direction < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
}
