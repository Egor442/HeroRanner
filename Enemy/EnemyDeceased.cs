using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class EnemyDeceased : MonoBehaviour, IEnemyDeceased
{
    private Animator _animator;

    public event UnityAction Died;

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    public void Die()
    {
        _animator.SetTrigger("Death");
        Died?.Invoke();
    }
}