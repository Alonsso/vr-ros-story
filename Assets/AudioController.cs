using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("Talking", true);
    }
    private void OnTriggerExit(Collider other)
    {
        audioSource.Stop();
        animator.SetBool("Talking", false);
    }
    private void Start()
    {
        animator.gameObject.SetActive(true);
    }
    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            animator.SetBool("Talking", false);
        }
    }
}
