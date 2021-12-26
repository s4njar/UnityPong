using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalWall : MonoBehaviour
{
    [SerializeField] private bool _isPlayerOne;
    [SerializeField] private ScoreManager _scoreManager;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
        _scoreManager.IncreaseScore(_isPlayerOne);
    }
}
