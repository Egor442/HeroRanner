using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PlayerMover _playerMover;
    [SerializeField] private PlayerDeceased _playerDeceased;
    [SerializeField] private PlayerDamager _playerDamager;
    [SerializeField] private PlayerAnimator _playerAnimator;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private Parallax _parallax;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private GameOverDisplay _gameOverDisplay;
    [SerializeField] private HealthDisplay _healthDisplay;

    private void Awake()
    {
        _player.Initialize();       
        _playerMover.Initialize();
        _playerDeceased.Initialize();
        _playerDamager.Initialize();
        _playerAnimator.Initialize();
        _playerInput.Initialize();
        _spawner.Initialize();
        _parallax.Initialize();
        _gameOverDisplay.Initialize();
        _healthDisplay.Initialize();
    }
}