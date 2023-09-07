using UnityEngine;
using UnityEngine.Events;

public class PlayerTouched : MonoBehaviour, IPlayerTouched
{
    [SerializeField] private AudioSource _audioTouched;

    public event UnityAction Touched;

    public void Touch()
    {
        _audioTouched.Play();
        Touched?.Invoke();
    }
}