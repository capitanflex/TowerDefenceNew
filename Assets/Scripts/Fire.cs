using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float range = 10f;
    public float damage = 10f;
    public float CurCoolDown, CoolDown;
    public GameObject Bullet;


    void Update()
        {
            if (CanShoot())
            {
                // вфывфывфыфыв
            }

            if(CurCoolDown > 0)
            {
                CurCoolDown -= Time.deltaTime;
            }
        }



    bool CanShoot()
    {
        if(CurCoolDown <= 0)
        {
            return true;
        }
        return false;
    }
    void SearchTarget()
    {
        GameObject nearstEnemy = null;
        float nearstEnemyDistanse = Mathf.Infinity;
        

        foreach (GameObject Enemy in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            float CurrDistance = Vector3.Distance(transform.position, Enemy.transform.position);
            
           if(CurrDistance < nearstEnemyDistanse && CurrDistance < range)
            {
                nearstEnemy = Enemy;
                nearstEnemyDistanse = CurrDistance;
            
            }
        }
        if (nearstEnemy != null)
        {
            Shoot(nearstEnemy);
                    
        }
    }

    void Shoot(GameObject Enemy)
    {
        CurCoolDown = CoolDown;
        GameObject proj = Instantiate(Bullet);
        proj.transform.position = transform.position;
        proj.GetComponent<BulletScript>().SetTarget(Enemy);
    }
}
