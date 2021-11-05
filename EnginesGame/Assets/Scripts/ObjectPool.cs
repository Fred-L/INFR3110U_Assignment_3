using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject Enemy;
    private Queue<GameObject> enemiesPool = new Queue<GameObject>();
    private int objectPoolStartSize = 5;

    private void Start()
    {
        for (int i = 0; i < objectPoolStartSize; i++)
        {
            GameObject enemy = Instantiate(Enemy);
            enemiesPool.Enqueue(enemy);
            enemy.SetActive(false);
        }
    }

    public GameObject GetEnemies()
    {
        if (enemiesPool.Count > 0)
        {
            GameObject enemy = enemiesPool.Dequeue();
            Enemy.SetActive(true);
            return enemy;
        }
        else
        {
            GameObject enemy = Instantiate(Enemy);
            return enemy;
        }
    }

    public void ReturnEnemies(GameObject enemy)
    {
        enemiesPool.Enqueue(enemy);
        enemy.SetActive(false);
    }
}
