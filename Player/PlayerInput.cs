using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerMover))]
public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Button _moveUpButton;
    [SerializeField] private Button _moveDownButton;

    private IPlayerMover _mover;

    public void Initialize()
    {
        _mover = GetComponent<PlayerMover>();
    }

    private void OnEnable()
    {
        _moveUpButton.onClick.AddListener(OnTryMoveUpButtonClick);
        _moveDownButton.onClick.AddListener(OnTryMoveDownButtonClick);
    }

    private void OnDisable()
    {
        _moveUpButton.onClick.RemoveListener(OnTryMoveUpButtonClick);
        _moveDownButton.onClick.RemoveListener(OnTryMoveDownButtonClick);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            _mover.TryMoveUp();

        if (Input.GetKeyDown(KeyCode.S))
            _mover.TryMoveDown();

        if (Input.GetKeyDown(KeyCode.UpArrow))
            _mover.TryMoveUp();

        if (Input.GetKeyDown(KeyCode.DownArrow))
            _mover.TryMoveDown();
    }

    private void OnTryMoveUpButtonClick()
    {
        _mover.TryMoveUp();
    }

    private void OnTryMoveDownButtonClick()
    {
        _mover.TryMoveDown();
    }
}