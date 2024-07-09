using UnityEngine;

public class scr_ZombieHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    private bool isDead;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    public bool IsDead()
    {
        return isDead;
    }

    void Die()
    {
        isDead = true;
        Debug.Log("Zombie is dead");
    }
}
