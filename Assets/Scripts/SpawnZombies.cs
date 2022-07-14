using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombies : MonoBehaviour
{
    [SerializeField] private Ghoul ghoulPrefab;
    [SerializeField] private float spawnStep = 1f;
    private float lifeTime = 0.5f;

    private float nextSpawnTime;

    void Start()
    {
        
    }


    void Update()
    {
        if (Time.time > spawnStep) 
        {
            var zombi = Instantiate(ghoulPrefab, transform);
            nextSpawnTime = Time.time + spawnStep;
            Destroy(zombi.gameObject, lifeTime);
        } 
    }
}
