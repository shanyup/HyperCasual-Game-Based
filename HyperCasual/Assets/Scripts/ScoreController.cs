using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public TMP_Text scoreText;
    private GameManager _gameManager;
    private float scoreDeltatime;
    private int score;
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        scoreText.text = score.ToString();
    }
    
    void Update()
    {
        if (_gameManager.isGameStart)
        {
            scoreDeltatime += Time.deltaTime * 10;
            score = (int)scoreDeltatime;
        }
        scoreText.text = (score.ToString());
    }
}
