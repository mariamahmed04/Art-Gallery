using UnityEngine;

public class  print : MonoBehaviour
{
    public GameObject uiPanel; 

    

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if (other.CompareTag("Player"))
        {
            uiPanel.SetActive(true);
            Debug.Log("Triggered");
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiPanel.SetActive(false);
        }
    }
}
