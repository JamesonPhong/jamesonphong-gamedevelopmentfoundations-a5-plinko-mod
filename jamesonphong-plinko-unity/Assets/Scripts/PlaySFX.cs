using UnityEngine;

public class PlaySFX : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AudioSource audioSource;
    public AudioClip audioClip;
    public void Play()
    {
        audioSource.Play();
        audioSource.PlayOneShot(audioClip);
    }
}
