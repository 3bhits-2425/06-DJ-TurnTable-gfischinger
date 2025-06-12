using UnityEngine;

public class Stop : MonoBehaviour
{
    public AudioSource audioSource;
    public Animator animator;
    public void OnClick()
    {
        if (audioSource.isPlaying) 
        {
            animator.SetBool("isPlaying", false);
            audioSource.Stop();
        }
    }
}
