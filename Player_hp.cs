using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_hp : MonoBehaviour
{
    public int maxHp = 100;
    private int currentHp;


    void Start()
    {
        currentHp = maxHp;
        //healtbar.SetMaxhp(maxHp);
    }

    public void TakeDmg(int damage)
    {
        currentHp -= damage;
        //healtbar.SetHealt(currentHp);

        if (currentHp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
