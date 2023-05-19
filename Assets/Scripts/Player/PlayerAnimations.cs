using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Player))]
public class PlayerAnimations : MonoBehaviour
{
    private Animator _animator;
    private Player _player;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _player = GetComponent<Player>();
    }

    private void OnEnable()
    {
        _player.Encountered += OnEncountered;
        _player.Died += OnDied;
    }

    private void OnDisable()
    {
        _player.Encountered -= OnEncountered;
        _player.Died -= OnDied;
    }

    private void OnEncountered()
    {
        _animator.SetTrigger("Attack");
    }

    private void OnDied()
    {
        _animator.SetTrigger("Death");
    }    
}