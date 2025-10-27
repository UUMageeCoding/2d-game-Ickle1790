using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 2MonsterDamage : MonoBehaviour
{
    public int damage = 5;
    public PlayerHealth playerHealth;

    private void OnCollisionEnter2d(Collision2d collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
        }
    }
}
