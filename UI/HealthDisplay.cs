using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private PlayerDamager _playerDamager;

    private Image[] _hearts;

    public void Initialize()
    {
        _hearts = GetComponentsInChildren<Image>();
    }

    private void OnEnable()
    {
        _playerDamager.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _playerDamager.HealthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged(int health)
    {
        for (int i = 0; i < _hearts.Length; i++)
        {
            if (i >= health)
                _hearts[i].DOFade(0, 0.5f);
        }
    }
}