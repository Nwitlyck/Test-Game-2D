using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    public float runSpeed;
    public float jumpStrenght;
    public float fallStrenght;
    public float lowStrenght;
    public Boolean betterJump;
    private Rigidbody2D rb;
    private Transform transform;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2 (-runSpeed, rb.velocity.y);
            transform.localScale = new Vector2(-1, 1);
        }

        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2 (runSpeed, rb.velocity.y);
            transform.localScale = new Vector2(1, 1);
        }
        else
        {
            rb.velocity = new Vector2 (0, rb.velocity.y);
        }        
        
        if (Input.GetKey(KeyCode.Space) && CheckGround.canJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpStrenght);
        }

        if (betterJump)
        {
            if(rb.velocity.x > 0)
            {
                rb.velocity += Vector2.up * Physics2D.gravity.y * fallStrenght * Time.deltaTime;
            }

            if(rb.velocity.x > 0 && !Input.GetKey(KeyCode.Space))
            {
                rb.velocity += Vector2.up * Physics2D.gravity.y * lowStrenght * Time.deltaTime;
            }
        }
    }
}
