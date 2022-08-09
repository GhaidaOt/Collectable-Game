using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip jumpSound, collectSound, winSound;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayPlayerJump()
    {
        audioSource.PlayOneShot(jumpSound);
    }

    public void PlayCollectSound()
    {
        audioSource.PlayOneShot(collectSound);
    }

    public void PlayWinSound()
    {
        audioSource.PlayOneShot(winSound);
    }
}
