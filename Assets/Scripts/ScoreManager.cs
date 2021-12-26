using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text _leftScoreText;
    [SerializeField] private Text _rightScoreText;
    private int _leftScore;
    private int _rightScore;

    public int LeftScore { 
        get => _leftScore; 
        set 
        {
            _leftScore = value;
            _leftScoreText.text = value.ToString();
        }
    }

    public int RightScore { 
        get => _rightScore;
        set
        {
            _rightScore = value;
            _rightScoreText.text = value.ToString();
        }
    }

    private void Start()
    {
        LeftScore = 0;
        RightScore = 0;
    }

    public void IncreaseScore(bool firstPlayer)
    {
        if (firstPlayer)
        {
            LeftScore++;        
        }
        else
        {
            RightScore++;
        }
    }

    public void ResetScore()
    {
        LeftScore = 0;
        RightScore = 0;
    }
}
