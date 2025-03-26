using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayAudioOnPress : MonoBehaviour
{
    public AudioSource audioSource; 
    private XRGrabInteractable buttonInteractable;

    void Start()
    {
        buttonInteractable = GetComponent<XRGrabInteractable>();

        buttonInteractable.activated.AddListener(PlayAudio);
    }

    void PlayAudio(ActivateEventArgs args)
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
