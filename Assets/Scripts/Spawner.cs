using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private GameObject[] _enemyPrefabs;
    [SerializeField] private float _secondsBetweenSpawn;

    private Transform[] _spawnPoints;
    private float _elepsedTime;

    public void Initialize()
    {
        _spawnPoints = GetComponentsInChildren<Transform>();

        _elepsedTime = 0;
        InitializePrefabe(_enemyPrefabs);
    }

    private void Update()
    {
        _elepsedTime += Time.deltaTime;

        if (_elepsedTime >= _secondsBetweenSpawn)
        {
            if (TryGetObject(out GameObject enemy))
            {
                _elepsedTime = 0;

                int spawnPointRandom = Random.Range(0, _spawnPoints.Length);
                SetEnemy(enemy, _spawnPoints[spawnPointRandom].position);
            }
        }
    }

    private void SetEnemy(GameObject enemy, Vector3 spawnPoint)
    {
        enemy.SetActive(true);
        enemy.transform.position = spawnPoint;
    }
}