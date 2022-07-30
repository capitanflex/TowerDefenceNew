using System.Collections;

using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;
    private void Start() 
    {
        StartCoroutine(SpawnTime());
    }
    
    IEnumerator SpawnTime()
        {
            for(int i = 0; i <= 4; i++)
            {
                yield return new WaitForSeconds(1.5f);
                
                Instantiate(Enemy, new Vector3(12.5209999f,0.100000001f,-13.2799997f), Quaternion.Euler(0,0,0));
            }

        }
}