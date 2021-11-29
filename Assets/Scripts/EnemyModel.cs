using UnityEngine;

public class EnemyModel : MonoBehaviour
{
    [SerializeField]
    private int _lives;

    [SerializeField]
    private int _speed;

    public int Lives { get { return _lives; } set { _lives = value; } }
    public int Speed { get { return _speed; } set { _speed = value; } }
}
