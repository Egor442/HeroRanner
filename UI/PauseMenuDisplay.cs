using UnityEngine;
using UnityEngine.UI;

public class PauseMenuDisplay : MonoBehaviour
{
    [SerializeField] private GameObject _pauseButton;
    [SerializeField] private Button _continueButton;

    private void OnEnable()
    {
        _continueButton.onClick.AddListener(OnContinueButtonClick);
    }

    private void OnDisable()
    {
        _continueButton.onClick.RemoveListener(OnContinueButtonClick);
    }

    private void OnContinueButtonClick()
    {
        Time.timeScale = 1;
        _pauseButton.SetActive(true);
        gameObject.SetActive(false);
    }
}