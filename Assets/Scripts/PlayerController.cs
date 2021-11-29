using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private PlayerModel _playerModel;

    [SerializeField]
    private PlayerView _playerView;

    [SerializeField]
    private GameObject _player;

    [SerializeField]
    private GameObject _gameOver;
    

    private void Awake()
    {
        _gameOver.SetActive(false);
    }

    private void Update()
    {
        Run();
        Jump();
        Die();
        ChangeNumberOfLives();
    }

    private void GetDamage()
    {
        _playerModel.Lives--;
    }

    private void Treatment()
    {
        if (_playerModel.Lives < _playerModel.MaxLives)
            _playerModel.Lives = _playerModel.MaxLives;
    }

    private void OnEnable()
    {
        _playerView.OnGetDamage += GetDamage;
        _playerView.OnGetTreatment += Treatment;        
    }

    private void OnDisable()
    {
        _playerView.OnGetDamage -= GetDamage;
        _playerView.OnGetTreatment -= Treatment;        
    }

    public void Run()
    {
        Vector3 direction = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, _playerModel.Speed * Time.deltaTime);
    }   

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && _playerView.IsGrounded == true)
        {
            _playerView.IsGrounded = false;
            _playerModel.Rigidbody2D.AddForce(transform.up * _playerModel.JumpForce, ForceMode2D.Impulse);
        }
    }
    
    private void Die()       
    {
        if (_player.transform.position.y < -5.0f || _playerModel.Lives <= 0)
        {
            _gameOver.SetActive(true);
        }
    }

    private void ChangeNumberOfLives()
    {      
        for (int i = 0; i < _playerView.lives.Length; i++)
        {
            if (i < _playerModel.Lives)
            {
                _playerView.lives[i].sprite = _playerView.FullLive;
            }
            else
            {
                _playerView.lives[i].sprite = _playerView.VoidLive;
            }

            if (i < _playerView.NumberOfLives)
            {
                _playerView.lives[i].enabled = true;
            }
            else
            {
                _playerView.lives[i].enabled = false;
            }
        }        
    }
}
