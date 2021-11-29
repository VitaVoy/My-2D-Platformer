using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    [SerializeField]
    private int _speed;

    [SerializeField]
    private int _lives;

    [SerializeField]
    private int _jumpForce;

    private Rigidbody2D _rigidbody2D;
    private int _maxLives;

    public int Lives { get { return _lives; } set { _lives = value; } }
    public int MaxLives { get { return _maxLives; } set { _maxLives = value; } }

    public int Speed { get { return _speed; } set { _speed = value; } }

    public Rigidbody2D Rigidbody2D { get { return _rigidbody2D; } set { _rigidbody2D = value; } }

    public int JumpForce { get { return _jumpForce; } set { _jumpForce = value; } }


    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _maxLives = _lives;
    }   
}
