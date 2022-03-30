﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class PlayerMovement : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private Vector2 _direction;
    private float _moveSpeed = 5f;
    private float _jumpForse = 500f;
    private bool _faceRight = true;

    private const string VectorX = "VectorX";

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        Run();
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _rigidbody.AddForce(new Vector3(0f, _jumpForse));
    }

    private void Run()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _animator.SetFloat(VectorX, Mathf.Abs(_direction.x));
        _rigidbody.velocity = new Vector2(_direction.x * _moveSpeed, _rigidbody.velocity.y);

        if (_faceRight == true && _direction.x < 0)
        {
            Flip();
        }
        else if (_faceRight == false && _direction.x > 0)
        {
            Flip();
        }
    }

    private void Flip()
    {
        _faceRight = !_faceRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
