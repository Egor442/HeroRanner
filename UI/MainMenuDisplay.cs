using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuDisplay : MonoBehaviour
{
    [SerializeField] private Button _playButton;
    [SerializeField] private TMP_Text _bestScoreText;

    private void OnEnable()
    {
        _playButton.onClick.AddListener(SwithOnGame);
    }

    private void OnDisable()
    {
        _playButton.onClick.RemoveListener(SwithOnGame);
    }

    private void Start()
    {
        _bestScoreText.text = PlayerPrefs.GetFloat("bestScore").ToString();
    }

    private void SwithOnGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}