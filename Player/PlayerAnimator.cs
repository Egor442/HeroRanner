using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimator : MonoBehaviour
{
    private Animator _animator;

    public void Initialize()
    {
        _animator = GetComponent<Animator>();
    }

    public void Die()
    {
        _animator.SetTrigger("Death");
    }

    public void TakeDamage()
    {      
        _animator.SetTrigger("Attack");
    }
}