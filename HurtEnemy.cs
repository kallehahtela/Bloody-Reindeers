using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour
{
    public int damageToGive = 1;
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Poro")
        {
            EnemyHealthManager eHealthMan;
            eHealthMan = other.gameObject.GetComponent<EnemyHealthManager>();
            
            eHealthMan.HurtEnemy(damageToGive);
        }
    }
}
