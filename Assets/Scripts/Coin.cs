using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    [SerializeField] private UnityEvent _destroyed = new UnityEvent();

    public event UnityAction Destroyed
    {
        add => _destroyed.AddListener(value);
        remove => _destroyed.RemoveListener(value);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Player player))
        {
            Destroy(gameObject);
            _destroyed?.Invoke();
        }
    }
}
