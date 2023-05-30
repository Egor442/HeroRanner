using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _damage;

    private Animator _animator;

    public event UnityAction Died;

    private void Die()
    {
        _animator.SetTrigger("Death");
        Died?.Invoke();
    }

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.TakeDamage(_damage);
            Die();
        }

        if (collision.gameObject.name == "Destroyer")
            gameObject.SetActive(false);
    }
}