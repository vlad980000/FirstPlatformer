using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCoin : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    [SerializeField] private float _timeBetweenSpawnCoins;

    private BoxCollider2D _boxCollider;
    private float _elapserTime = 0;

    private void Start()
    {
        CreateCoin();
    }

    private void Update()
    {
        _elapserTime += Time.deltaTime;

        if( _coin == null && _elapserTime >= _timeBetweenSpawnCoins)
        {
            CreateCoin();
        }
    }

    private void CreateCoin()
    {
        Instantiate(_coin);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<Player>(out Player player))
        {
            Destroy(_coin);
        }
    }
}
