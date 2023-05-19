using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private Player _player;

    public float NumberScore { get; private set; }

    private void Update()
    {
        if (_player.IsDied == false)
        {
            NumberScore += Time.deltaTime;
            _scoreText.text = NumberScore.ToString();
        }
    }
}