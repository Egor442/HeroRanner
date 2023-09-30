using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(EnemyMover))]
[RequireComponent(typeof(EnemyDeceased))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyData _data;

    private IEnemyMover _enemyMover;
    private IEnemyDeceased _enemyDeceased;

    private void Awake()
    {
        _enemyMover = GetComponent<EnemyMover>();
        _enemyDeceased = GetComponent<EnemyDeceased>();
    }

    private void Update()
    {
        _enemyMover.Move();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.TakeDamage(_data.Damage);
            _enemyDeceased.Die();
        }

        if (collision.gameObject.name == "Destroyer")
        {
            gameObject.SetActive(false);
        }
    }
}