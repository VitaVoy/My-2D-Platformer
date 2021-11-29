using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _minX;

    [SerializeField]
    private float _maxX;

    private int _direction = 1;
    private bool _bounced = false;


    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(_direction * _speed * Time.deltaTime, 0, 0);

        if (transform.position.x > _maxX || transform.position.x < _minX)
        {
            _direction = -_direction;
            _bounced = true;
        }
        if (_bounced)
        {
            transform.Translate(_direction * _speed * Time.deltaTime, 0, 0);
        }
    }
}
