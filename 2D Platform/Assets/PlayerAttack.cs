using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int damage;

    private Rigidbody2D rb2d;

    /*void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }*/

    // Update is called once per frame
    void Update()
    {

        if (timeBtwAttack <= 1)
        {
            
            //then you can attack
            if (Input.GetKey(KeyCode.Space))
            {
                
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                Debug.Log(enemiesToDamage.Length);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    
                    Debug.Log("Die");
                    enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                    Destroy(enemiesToDamage[i].gameObject);
                }
                {

                }
            }

            timeBtwAttack = startTimeBtwAttack;
        } else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }


    void OnDrawGizmos()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);

    }
}

