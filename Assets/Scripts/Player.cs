using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private List<Coin> _coins;
    private BoxCollider2D _boxCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))
        {
            _coins.Add(coin);
            Destroy(collision.gameObject);
        }
    }
}
