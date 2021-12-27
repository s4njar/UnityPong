using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalWall : MonoBehaviour
{
    [SerializeField] private bool _isPlayerOne;
    [SerializeField] private ScoreManager _scoreManager;
    [SerializeField] private Ball _ball;

    private void OnCollisionEnter2D(Collision2D other)
    {
        _ball.ResetBall();
        _scoreManager.IncreaseScore(_isPlayerOne);
    }
}
