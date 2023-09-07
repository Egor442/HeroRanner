using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
using TMPro;

[RequireComponent(typeof(CanvasGroup))]
public class GameOverDisplay : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _mainMenuBatton;
    [SerializeField] private ScoreDisplay _scoreDisplay;
    [SerializeField] private TMP_Text _resultNumberScoreText;
    [SerializeField] private PlayerDeceased _playerDeceased;

    private CanvasGroup _gameOverGroup;

    public void Initialize()
    {
        _gameOverGroup = GetComponent<CanvasGroup>();
    }

    private void OnEnable()
    {
        _playerDeceased.Died += OnDied;
        _restartButton.onClick.AddListener(OnRestartButtonClick);
        _mainMenuBatton.onClick.AddListener(SwithOnMainMenu);
    }

    private void OnDisable()
    {
        _playerDeceased.Died -= OnDied;
        _restartButton.onClick.RemoveListener(OnRestartButtonClick);
        _mainMenuBatton.onClick.RemoveListener(SwithOnMainMenu);
    }

    private void OnDied()
    {
        _gameOverGroup.DOFade(1, 0.2f).SetEase(Ease.Linear);

        _resultNumberScoreText.text = _scoreDisplay.Score.ToString();

        if (_gameOverGroup.alpha == 1 && _playerDeceased.IsDied)
            Time.timeScale = 0;
    }

    private void OnRestartButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    private void SwithOnMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}