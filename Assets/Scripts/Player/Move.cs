using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float runSpeed;
    public float jumpStrenght;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.velocity = new Vector2 (-runSpeed, rb.velocity.x);
        }

        else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.velocity = new Vector2 (runSpeed, rb.velocity.y);
        }
    }
}
