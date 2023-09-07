using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerDamager))]
[RequireComponent(typeof(PlayerTouched))]
public class Player : MonoBehaviour
{
    private IPlayerDamager _playerDamager;
    private IPlayerTouched _playerTouched;

    public void Initialize()
    {
        _playerDamager = GetComponent<PlayerDamager>();
        _playerTouched = GetComponent<PlayerTouched>();
    }

    public void TakeDamage(int damage)
    {       
        _playerDamager.TakeDamage(damage);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Enemy enemy))
            _playerTouched.Touch();
    }
}