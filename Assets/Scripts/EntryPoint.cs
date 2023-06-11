using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PlayerMover _playerMover;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private Parallax _parallax;
    [SerializeField] private Spawner _spawner;

    private void Awake()
    {
        _player.Initialize();       
        _playerMover.Initialize();
        _playerInput.Initialize();
        _spawner.Initialize();
        _parallax.Initialize();
    }
}