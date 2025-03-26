using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayAudioOnGrab : MonoBehaviour
{
    public GameObject text;

    private AudioSource audioSource;
    private XRGrabInteractable grabInteractable;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        grabInteractable = GetComponent<XRGrabInteractable>();

        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.AddListener(OnGrab);
            grabInteractable.selectExited.AddListener(OnRelease);
        }
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }

        if (grabInteractable != null)
        {
            text.gameObject.SetActive(true);
        }
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        if (audioSource != null)
        {
            audioSource.Stop();
        }

        if (grabInteractable != null)
        {
            text.gameObject.SetActive(false);
        }
    }

    private void OnDestroy()
    {
        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.RemoveListener(OnGrab);
            grabInteractable.selectExited.RemoveListener(OnRelease);
        }
    }
}
