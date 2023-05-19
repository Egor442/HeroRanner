using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenuDisplay;

    public void OnPauseButtonClick()
    {
        _pauseMenuDisplay.SetActive(true);
        Time.timeScale = 0;
        gameObject.SetActive(false);
    }
}