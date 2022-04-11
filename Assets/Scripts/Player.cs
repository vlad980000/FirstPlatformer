﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Player : MonoBehaviour
{ 
    private List<Coin> _coins = new List<Coin>();
    private BoxCollider2D _boxCollider;

    public int Money { get; set; }

    private void Start()
    {
        GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Coin coin))
        {
            _coins.Add(coin);
        }
    }
}
