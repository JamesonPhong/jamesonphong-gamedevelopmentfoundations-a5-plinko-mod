using UnityEngine;

public class ExplosionSFX : MonoBehaviour
{
    // Call upon a source of Audio
    public AudioSource audioSource;
    public void ExplosionSoundFX()
    {
        audioSource.Play();
    }
}
