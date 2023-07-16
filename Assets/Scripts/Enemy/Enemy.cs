using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyData _data;

    private Animator _animator;

    public event UnityAction Died;

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    private void Die()
    {
        _animator.SetTrigger("Death");
        Died?.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.TakeDamage(_data.Damage);
            Die();
        }

        if (collision.gameObject.name == "Destroyer")
            gameObject.SetActive(false);
    }
}