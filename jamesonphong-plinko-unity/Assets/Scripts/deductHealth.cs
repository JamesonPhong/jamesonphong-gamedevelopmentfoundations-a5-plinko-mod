using UnityEngine;

public class DeductHealth : MonoBehaviour
{
    public HealthTracker healthTracker;
    public ExplosionSFX explosionSFX;
    public int health = 1;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        healthTracker.deductHealth(health);
        Destroy(collider.gameObject);
        explosionSFX.ExplosionSoundFX();
    }
}