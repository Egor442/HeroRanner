using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerAnimator))]
public class PlayerDeceased : MonoBehaviour
{
    [SerializeField] private AudioSource _audioDiead;
    [SerializeField] private GameObject _gameOverScreen;

    private PlayerAnimator _playerAnimator;   

    public bool IsDied { get; private set; }

    public event UnityAction Died;

    public void Initialize()
    {
        _playerAnimator = GetComponent<PlayerAnimator>();
        IsDied = false;
    }

    public void Die()
    {
        _playerAnimator.Die();
        _audioDiead.Play();

        _gameOverScreen.SetActive(true);

        IsDied = true;
        Died?.Invoke();
    }
}