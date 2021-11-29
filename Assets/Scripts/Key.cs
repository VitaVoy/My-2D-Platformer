using UnityEngine;

public class Key : MonoBehaviour 
{
    [SerializeField]
    private float _minY;

    [SerializeField]
    private float _maxY;

    [SerializeField]
    private GameObject _door;

    [SerializeField]
    private GameObject _key;

    private int _speed = 1;

    private int _direction = 1;
    private bool _bounced = false;
    private void Update()
    {
        Run();
    }

    public void Run()
    {
        transform.Translate(0, _direction * _speed * Time.deltaTime, 0);
        if (transform.position.y > _maxY || transform.position.y < _minY)
        {
            _direction = -_direction;
            _bounced = true;
        }
        if (_bounced)
        {
            transform.Translate(_direction * _speed * Time.deltaTime, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerView player))
        {
            _key.SetActive(false);
            _door.SetActive(false);
        }
    }
}
