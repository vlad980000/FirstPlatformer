using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCoins : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Coin _coin;

    private void Start()
    {
        SpawnCoin();
    }

    private void SpawnCoin()
    {
        Instantiate(_coin, _spawnPoint);
    }

    private void OnEnable()
    {
        Coin.OnDestroyed += SpawnCoin;
    }

    private void OnDesable()
    {
        Coin.OnDestroyed -= SpawnCoin;
    }
}
