using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawn : MonoBehaviour
{
    public GameObject Enemy;
    public float x;
    public float z;
    public int enemyCount;
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }
    IEnumerator EnemySpawn()
    {
        while(enemyCount<5)
        {
            x = Random.Range(2.5f,32.5f);
            z = Random.Range(-20f, 22.5f);

            Instantiate(Enemy, new Vector3(x, 0.7f, z),Quaternion.identity);
            yield return new WaitForSeconds(0.4f);
            enemyCount++;
        }
    }
}
