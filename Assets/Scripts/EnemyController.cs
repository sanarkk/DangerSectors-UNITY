using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float health = 10.0f;
   

   

    public void TakeDamage(float amt)
    {
        health -= amt;
        if(health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        gameObject.SetActive(false);
        PortalController.Instance.score += 1;
    }
}
