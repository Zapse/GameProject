using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//here we make player combat script. We have here input what player needs to press to perform attack, animator trigger and collider for "scan" if you hitted enemy.
public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform AttackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.P))
        {
            Attack();
        }

    }

    void Attack()
    {
        animator.SetTrigger("Attack"); //just the animation row, attack trigger and transfer back to idle have been made in animator.

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            //enemy.GetComponent<Enemy_hp>().TakeDmg(100);
            Debug.Log("osu" + enemy.name);
            CameraShake.Instance.ShakeCamera(.5f, .5f);
            
        }
    }

    void OnDrawGizmosSelected()
    {
        if (AttackPoint == null)
            return;
        Gizmos.DrawWireSphere(AttackPoint.position, attackRange);
    }

}
