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
        _coin.Destroyed += OnCoinDestroed;
    }

    private void OnDisable()
    {
        _coin.Destroyed -= OnCoinDestroed;
    }

    private void OnCoinDestroed()
    {
        SpawnCoin();
    }
}
