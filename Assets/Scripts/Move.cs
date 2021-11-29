using UnityEngine;

public class Move : EnemyController
{
    [SerializeField]
    private float _minX;

    [SerializeField]
    private float _maxX;

    private int _direction = 1;
    private bool _bounced = false;

    private void Update()
    {
        Run();
    }

    private void Run()
    {
        transform.Translate(_direction * EnemyModel.Speed * Time.deltaTime, 0, 0);

        if (transform.position.x > _maxX || transform.position.x < _minX)
        {
            _direction = -_direction;
            _bounced = true;
        }

        if (_bounced)
            transform.Translate(_direction * EnemyModel.Speed * Time.deltaTime, 0, 0);
    }
}
