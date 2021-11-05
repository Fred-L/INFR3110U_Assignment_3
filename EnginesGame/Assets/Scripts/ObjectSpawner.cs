using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    //holds whatever object that you want to spawn
    public GameObject entityHolder;

    //holds the spawner drag spawner into here
    public GameObject spawner;

    //changes how long it takes between each spawn
    public float spawnTimer = 5.0f;
    private float timer;
    private ObjectPool objectPool;

    private void Start()
    {
        objectPool = FindObjectOfType<ObjectPool>();
    }

    void Update()
    {
        if (!GlobalVariableScript.Instance.inEditor)
        {
            // internal counter
            timer += Time.deltaTime;
            if (timer >= spawnTimer)
            {
                GameObject newObject = objectPool.GetEnemies();
                newObject.transform.position = this.transform.position;

                //Resets timer once it hits the spawnTimer
                timer = 0f;
            }
        }
    }
}
