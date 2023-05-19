using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuDisplay : MonoBehaviour
{
    [SerializeField] private Button _playButton;

    private void OnEnable()
    {
        _playButton.onClick.AddListener(OnPlayButtonClick);
    }

    private void OnDisable()
    {
        _playButton.onClick.RemoveListener(OnPlayButtonClick);
    }

    private void OnPlayButtonClick()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}