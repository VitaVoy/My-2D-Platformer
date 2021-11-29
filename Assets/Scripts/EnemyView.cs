using UnityEngine;
using System;

public class EnemyView : MonoBehaviour
{
    public event Action OnGetEnemyDamage;
    public event Action OnEnemyDie;

    public void GetEnemyDamage() //метод который вызывает эвент
    {

        OnGetEnemyDamage?.Invoke();
    }

    public void EnemyDie()
    {
        OnEnemyDie?.Invoke();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerView player))
            player.GetDamage();
    }
}
