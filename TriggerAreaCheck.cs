using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAreaCheck : MonoBehaviour
{
    private Enemy_behaviour enemyParent;
    //GameObject Player;

    private void Awake()
    {
        enemyParent = GetComponentInParent<Enemy_behaviour>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            //Player.GetComponent<Player_hp>().TakeDmg(50);
            gameObject.SetActive(false);
            enemyParent.target = collider.transform;
            enemyParent.inRange = true;
            enemyParent.hotZone.SetActive(true);
            //Debug.Log("we hit" + gameObject.name);
        }

    }
}
