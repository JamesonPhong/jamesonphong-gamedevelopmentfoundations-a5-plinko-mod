using TMPro;
using UnityEngine;

public class HealthTracker : MonoBehaviour
{
    public TMP_Text healthDisplay;
    public int health = 9000;

    private void Start()
    {
        UpdateHealthDisplay();
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
}