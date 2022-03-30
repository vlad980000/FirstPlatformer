using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform[] _movePoints;
    [SerializeField] private float _speed;

    private SpriteRenderer _spriteRenderer;
    private int _pointIndex;
    private Vector2 _direction;

    private void Start()
    {
        _direction = _movePoints[0].position;
    }

    private void Update()
    {
        Walk();
    }

    private void Walk()
    {
        float distanse = 0.3f;
        float step = _speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, _direction, step);

        if (Vector3.Distance(transform.position, _direction) < distanse)
            MovementPointChose();
    }

    private void MovementPointChose()
    {
        _pointIndex = ++_pointIndex < _movePoints.Length ? _pointIndex : 0;
        _direction = _movePoints[_pointIndex].position;

        Flip();
    }

    private void Flip()
    {
        GetComponent<SpriteRenderer>().flipX = _direction.x < transform.position.x;
    }
}
