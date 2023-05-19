using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyAnimations : MonoBehaviour
{
    private Animator _animator;
    private Enemy _enemy;

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
        _enemy = GetComponent<Enemy>();
    }

    private void OnEnable()
    {
        _enemy.Died += OnDied;
    }

    private void OnDisable()
    {
        _enemy.Died -= OnDied;
    }

    private void OnDied()
    {
        _animator.SetTrigger("Death");
    }
}