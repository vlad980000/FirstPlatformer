using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class Player : MonoBehaviour
{
    private int _money;
    private BoxCollider2D _boxCollider;

    public int Money => _money;

    public event UnityAction MoneyChanged;

    private void Start()
    {
        GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Coin coin))
        {
            AddMoney(coin.Cost);
        }
    }

    public void AddMoney(int coinCost)
    {
        MoneyChanged?.Invoke();
        _money += coinCost;
    }
}
