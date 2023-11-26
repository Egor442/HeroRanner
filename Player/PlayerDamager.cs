using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerAnimator))]
[RequireComponent(typeof(PlayerDeceased))]
public class PlayerDamager : MonoBehaviour
{
    [SerializeField] private int _health;

    private PlayerAnimator _playerAnimator;
    private PlayerDeceased _playerDeceased;

    public event UnityAction<int> HealthChanged;

    public void Initialize()
    {
        _playerAnimator = GetComponent<PlayerAnimator>();
        _playerDeceased = GetComponent<PlayerDeceased>();

        HealthChanged?.Invoke(_health);
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        HealthChanged?.Invoke(_health);

        _playerAnimator.TakeDamage();

        if (_health <= 0)
        {
            _playerDeceased.Die();
        }
    }
}