using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private GameObject _health;

    [SerializeField]
    private float _minY;

    [SerializeField]
    private float _maxY;

    private int _direction = 1;

    private int _speed = 1;

    private bool _bounced = false;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(0, _direction * _speed * Time.deltaTime, 0);
        if (transform.position.y > _maxY || transform.position.y < _minY)
        {
            _direction = -_direction;
            _bounced = true;
        }

        if (_bounced)
            transform.Translate(0, _direction * _speed * Time.deltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerView player))
        {
            player.GetTratment();
            _health.SetActive(false);
        }
    }
}
