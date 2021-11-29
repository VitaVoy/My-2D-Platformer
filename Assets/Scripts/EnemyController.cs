using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public EnemyModel EnemyModel;

    public EnemyView EnemyView;    

    private void OnEnable()
    {
        EnemyView.OnGetEnemyDamage += GetEnemyDamage;
        EnemyView.OnEnemyDie += Die;
    }

    private void OnDisable()
    {
        EnemyView.OnGetEnemyDamage -= GetEnemyDamage;
        EnemyView.OnEnemyDie -= Die;
    }
    private void GetEnemyDamage()
    {
        EnemyModel.Lives--;
        if (EnemyModel.Lives <= 0)
            Destroy(gameObject);
    }

    private void Die()
    {
        if (EnemyModel.Lives <= 0)
            Debug.Log("Die");
            Destroy(gameObject);
    }
}
