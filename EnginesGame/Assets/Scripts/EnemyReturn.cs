using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyReturn : MonoBehaviour
{
    private ObjectPool objectPool;

    private void Start()
    {
        objectPool = FindObjectOfType<ObjectPool>();
    }

    private void OnDisable()
    {
        if (objectPool != null)
            objectPool.ReturnEnemies(this.gameObject);
    }
}
