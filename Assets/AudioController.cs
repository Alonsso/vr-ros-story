using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ALVV ?????????????");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Si entraa >>>>>>>");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Stop audio Trigger >>>>>>");
        audioSource.Stop();
    }
}
