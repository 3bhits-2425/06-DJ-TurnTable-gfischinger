using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayPause : MonoBehaviour
{
    public AudioSource audioSource;
    public Animator animator;

    public void OnClick()
    {
        if (audioSource.isPlaying) 
        {
            animator.SetBool("isPlaying", false);
            audioSource.Pause();
        }
        else
        {
            animator.SetBool("isPlaying", true);
            audioSource.Play();
        }
    }

}
