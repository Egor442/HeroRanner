using UnityEngine;

public class EnemyMover : MonoBehaviour, IEnemyMover
{
    [SerializeField] private EnemyData _data;

    public void Move()
    {
        transform.Translate(Vector3.left * _data.Speed * Time.deltaTime);
    }
}