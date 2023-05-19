using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerAudio : MonoBehaviour
{
    [SerializeField] private AudioSource _audioEncountered;
    [SerializeField] private AudioSource _audioDiead;

    private Player _player;

    private void Awake()
    {
        _player = GetComponent<Player>();
    }

    private void OnEnable()
    {
        _player.Encountered += OnEncounteredAudio;
        _player.Died += OnDiedAudio;
    }

    private void OnDisable()
    {
        _player.Encountered -= OnEncounteredAudio;
        _player.Died -= OnDiedAudio;
    }

    private void OnEncounteredAudio()
    {
        _audioEncountered.Play();
    }

    private void OnDiedAudio()
    {
        _audioDiead.Play();
    }
}