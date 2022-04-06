using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCoins : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private float _timeBetweenSpawn;

    private void Start()
    {
        SpawnCoin();
    }

    private void SpawnCoin()
    {
        Instantiate(_coinPrefab, _spawnPoint);
    }
}
