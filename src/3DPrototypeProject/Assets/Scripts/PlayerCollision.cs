using StarterAssets;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject interactionText;
    private PlayerInteraction _playerInteraction;

    private void Start()
    {
        _playerInteraction = GetComponent<PlayerInteraction>();
        interactionText.SetActive(false);
    }

    // Trigger'a girdiğinde çalışır
    private void OnTriggerEnter(Collider otherCollidedObject)
    {
        if (otherCollidedObject.CompareTag("Interact"))
        {
            _playerInteraction.CanInteract = true;
            _playerInteraction.interactionArea = otherCollidedObject.gameObject.GetComponent<InteractionArea>();
            interactionText.SetActive(true);
        }
    }
    
    // Trigger'dan çıktığında çalışır
    private void OnTriggerExit(Collider otherCollidedObject)
    {
        if (otherCollidedObject.CompareTag("Interact"))
        {
            _playerInteraction.CanInteract = false;
            _playerInteraction.interactionArea = null;
            interactionText.SetActive(false);
        }
    }
}