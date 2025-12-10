using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthTracker : MonoBehaviour
{
    public TMP_Text healthDisplay;
    public int health = 9000;

    private void Start()
    {
        UpdateHealthDisplay();
    }
    private void Update()
    {
        ZeroHealth();
    }
    public void deductHealth(int damage)
    {
        health -= damage;
        UpdateHealthDisplay();
    }
    public void UpdateHealthDisplay()
    {
        healthDisplay.text = $"HEALTH: {health,000000000}";
    }
    public void ZeroHealth()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}