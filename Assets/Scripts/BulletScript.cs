using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    GameObject target;
    float speed = 10f;
    public float damage = 10f;
    private GameObject enemy;
    private EnemyHelth enemyHelthScript;

    

    void Update()
    {
        Move();
    }

    public void SetTarget(GameObject Enemy)
    {
      target = Enemy;  
      
    }
    
    private void Move()
    {
        
        if(target != null)
        {
            
            enemyHelthScript = target.GetComponent<EnemyHelth>();
            if(Vector3.Distance(transform.position, target.transform.position) < 0.8f)
            {
                Destroy(gameObject);
                enemyHelthScript.HitHP(damage);
            }
            else
            {
                Vector3 dir = target.transform.position - transform.position;
                transform.Translate(dir.normalized * Time.deltaTime * speed);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
