using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCoins : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Coin _coin;

    private void SpawnCoin()
    {
        _coin.Show();
    }

    private void OnEnable()
    {
        _coin.Destroyed += OnDestroyed;
    }

    private void OnDisable()
    {
        _coin.Destroyed -= OnDestroyed;
    }

    private void OnDestroyed()
    {
        Invoke(nameof(SpawnCoin),3f);
    }
}
