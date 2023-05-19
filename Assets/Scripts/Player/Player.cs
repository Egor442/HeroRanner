using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private GameObject _gameOverScreen;

    public event UnityAction<int> HealthChanged;
    public event UnityAction Died;
    public event UnityAction Encountered;

    public bool IsDied { get; private set; }

    private void Start()
    {
        IsDied = false;
        HealthChanged?.Invoke(_health);
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        HealthChanged?.Invoke(_health);

        if(_health <= 0)
            Die();
    }

    public void Die()
    {
        _gameOverScreen.SetActive(true);
        IsDied = true;
        Died?.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Enemy enemy))
            Encountered?.Invoke();
    }
}