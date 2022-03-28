using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(SpriteRenderer))]
public class MoveEnemies : MonoBehaviour
{
    [SerializeField] Transform _movePoint;
    [SerializeField] float _moveTime;

    private bool _isFaceRight = true;
    private SpriteRenderer _spriteRenderer;
    private Vector2 _direction;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        transform.DOMove(new Vector3(_movePoint.position.x,_movePoint.position.y,0),_moveTime).SetLoops(-1,LoopType.Yoyo);
    }

    private void FixedUpdate()
    {
        if (_isFaceRight == true && _movePoint.position.x < 0)
        {
            Flip();
        }
        else if (_isFaceRight == false && _movePoint.position.x > 0)
        {
            Flip();
        }
    }

    private void Flip()
    {
        _isFaceRight = !_isFaceRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
