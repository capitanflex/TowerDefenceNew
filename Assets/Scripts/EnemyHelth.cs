
using UnityEngine;

public class EnemyHelth : MonoBehaviour
{
    public float hp = 100;
    
    
    void Update()
    {
        
    }

    public void HitHP(float damage)
    {
        hp -= damage;
       
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
