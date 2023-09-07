using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerAnimator))]
[RequireComponent(typeof(PlayerDeceased))]
public class PlayerDamager : MonoBehaviour, IPlayerDamager
{
    [SerializeField] private int _health;

    private IPlayerAnimator _playerAnimator;
    private IPlayerDeceased _playerDeceased;

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
            _playerDeceased.Die();
    }
}