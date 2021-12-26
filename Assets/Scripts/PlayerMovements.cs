using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private Vector2? _direction = null;
    [SerializeField] private bool _isPlayerOne;
    [SerializeField] private int _speed = 15;
    [SerializeField] private Rigidbody2D rb;
    private float _movement;

    void Update()
    {
        _movement = Input.GetAxisRaw(_isPlayerOne ? "Player1" : "Player2");

        rb.velocity = new Vector2(rb.velocity.x, _movement * _speed);
    }
}