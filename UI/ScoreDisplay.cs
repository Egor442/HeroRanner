using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private PlayerDeceased _playerDeceased;

    public float Score { get; private set; }

    private void OnEnable()
    {
        _playerDeceased.Died += TryAddBestScore;
    }

    private void OnDisable()
    {
        _playerDeceased.Died -= TryAddBestScore;
    }

    private void Update()
    {
        if (_playerDeceased.IsDied == false)
        {
            Score += Time.deltaTime;
            _scoreText.text = Score.ToString();
        }
    }

    private void TryAddBestScore()
    {
        if (PlayerPrefs.GetFloat("bestScore") < Score)
        {
            PlayerPrefs.SetFloat("bestScore", Score);
            PlayerPrefs.Save();
        }
    }
}