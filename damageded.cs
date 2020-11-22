using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this is code for enemy Ai to damage player.
public class damageded : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {  
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("iskin pelaajaa");
            collision.GetComponent<Player_hp>().TakeDmg(20); //lets call player_hp script and inside it TakeDmg function.
        }
    }
}
