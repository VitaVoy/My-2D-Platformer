using UnityEngine;
using System;
using UnityEngine.UI;

public class PlayerView : MonoBehaviour
{
    public event Action OnGetDamage;
    public event Action OnGetTreatment;

    private bool _isGrounded;

    public int NumberOfLives;
    public Sprite FullLive;
    public Sprite VoidLive;

    public Image[] lives;

    public bool IsGrounded { get { return _isGrounded; } set { _isGrounded = value; } }

    public void GetDamage()
    {
        OnGetDamage?.Invoke();
    }

    public void GetTratment()
    {
        OnGetTreatment?.Invoke();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _isGrounded = true;
       
        if (collision.gameObject.TryGetComponent(out EnemyView enemy))
            enemy.GetEnemyDamage();
    }    
}
