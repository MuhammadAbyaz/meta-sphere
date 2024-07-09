using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scr_PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public GameObject restartButton;
    public Image healthBar;
    public Image health;
    public Canvas gameOver;
    void Start()
    {
        gameOver.gameObject.SetActive(false);
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
            Time.timeScale = 0;

            gameOver.gameObject.SetActive(true);
        }
        UpdateHealthBar();
    }

    void Die()
    {
        PauseAllAudio();
        Debug.Log("Player is dead");
    }
    void UpdateHealthBar()
    {
        float healthPercentage = (float)currentHealth / maxHealth;
        health.fillAmount = healthPercentage;
    }
    void PauseAllAudio(){
        AudioListener.pause = true;
    }
    public void RestartGame(){
        AudioListener.pause = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
