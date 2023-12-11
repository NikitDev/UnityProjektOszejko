using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CastleHealth : MonoBehaviour
{
    public int maxHealth = 200;
    private int currentHealth;

    public GameObject GameOverMenuUI;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Time.timeScale = 0f;
            GameOverMenuUI.SetActive(true);
        }
    }
}
