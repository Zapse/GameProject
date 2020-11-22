using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Simple healt script.
public class Enemy_hp : MonoBehaviour
{
    public int maxHp = 100;
    int currentHp;

    //public HealtBar healtbar;
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
