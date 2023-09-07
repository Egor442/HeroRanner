using UnityEngine;

public class EnemyMover : MonoBehaviour, IEnemyMover
{
    public void Move(float speed)
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}