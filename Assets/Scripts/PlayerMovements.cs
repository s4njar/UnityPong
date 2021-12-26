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
        //if (Input.GetKeyDown(KeyCode.Z))
        //{
        //    _direction = Vector2.up;
        //}
        //else if (Input.GetKeyDown(KeyCode.S))
        //{
        //    _direction = Vector2.down;
        //}

        //if (_direction == null) return;
        //this.transform.position = new Vector2(this.transform.position.x + _direction.Value.x / _playerSpeed, this.transform.position.y + _direction.Value.y / _playerSpeed  );
    }
}