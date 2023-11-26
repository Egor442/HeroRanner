using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _stepSize;
    [SerializeField] private float _maxHeight;
    [SerializeField] private float _minHeihgt;

    private Vector3 _targetPosition;

    public void Initialize()
    {
        _targetPosition = transform.position;
    }

    public void TryMoveUp()
    {
        if (_targetPosition.y < _maxHeight)
        {
            _targetPosition = new Vector2(_targetPosition.x, _targetPosition.y + _stepSize);
        }
    }

    public void TryMoveDown()
    {
        if (_targetPosition.y > _minHeihgt)
        {
            _targetPosition = new Vector2(_targetPosition.x, _targetPosition.y - _stepSize);
        }
    }

    private void Update()
    {
        if (transform.position != _targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _moveSpeed * Time.deltaTime);
        }
    }  
}