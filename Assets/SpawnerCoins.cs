using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCoins : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private float _timeBetweenSpawn;

    private void Start()
    {
        Instantiate(_coinPrefab,_spawnPoint);
    }
}
