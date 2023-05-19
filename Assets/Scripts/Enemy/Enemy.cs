using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _damage;

    public event UnityAction Died;

    private void Die()
    {
        Died?.Invoke();
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