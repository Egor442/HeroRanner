using UnityEngine;

[CreateAssetMenu(fileName = "new Enemy", menuName = "new Enemy", order = 51)]
public class EnemyData : ScriptableObject
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;

    public int Damage => _damage;
    public float Speed => _speed;
}