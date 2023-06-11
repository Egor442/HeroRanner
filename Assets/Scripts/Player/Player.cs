using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private GameObject _gameOverScreen;
    [SerializeField] private AudioSource _audioEncountered;
    [SerializeField] private AudioSource _audioDiead;

    private Animator _animator;

    public event UnityAction<int> HealthChanged;
    public event UnityAction Died;
    public event UnityAction Encountered;

    public bool IsDied { get; private set; }  

    public void Initialize()
    {
        _animator = GetComponent<Animator>();

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
        _animator.SetTrigger("Death");
        _audioDiead.Play();

        _gameOverScreen.SetActive(true);

        IsDied = true;

        Died?.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Enemy enemy))
        {
            _animator.SetTrigger("Attack");
            _audioEncountered.Play();

            Encountered?.Invoke();
        }
    }
}