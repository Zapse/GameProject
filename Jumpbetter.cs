using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is player script what makes jumping feel more "gamelike".
public class Jumpbetter : MonoBehaviour
{
    public float fallMulti = 2f;
    public float lowJumpMulti = 1.5f;

    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMulti - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMulti - 1) * Time.deltaTime;
        }
    }
}
