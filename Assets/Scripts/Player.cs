using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Player : MonoBehaviour
{
<<<<<<< Updated upstream
    private List<Coin> _coins = new List<Coin>();
=======
    [SerializeField] private int _money;

>>>>>>> Stashed changes
    private BoxCollider2D _boxCollider;

    private void Start()
    {
        GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))
        {
            _coins.Add(coin);
            Destroy(collision.gameObject);
        }
    }
}
