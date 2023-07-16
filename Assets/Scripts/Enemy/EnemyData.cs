using UnityEngine;

[CreateAssetMenu(fileName = "new Enemy", menuName = "new Enemy", order = 51)]
public class EnemyData : ScriptableObject
{
    [SerializeField] private int _damage;

    public int Damage => _damage;
}