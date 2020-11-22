using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Here we make Grounded script for player, because if we don't do this, you can just continue jumping when you are in air.
public class Grounded : MonoBehaviour
{
    GameObject Player;
    
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground") //The blocks in ground are tagged "Ground". 
        {
            Player.GetComponent<Move2D>().isGrounded = true;
        }
         if (collision.collider.tag == "Enemy") //This will allow player to jump off on AI's head.
        {
            Player.GetComponent<Move2D>().isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<Move2D>().isGrounded = false;
        }
    
    }
}
