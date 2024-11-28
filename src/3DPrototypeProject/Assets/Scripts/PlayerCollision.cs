using StarterAssets;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Trigger'a girdiğinde çalışır
    private void OnTriggerEnter(Collider otherCollidedObject)
    {
        if (otherCollidedObject.CompareTag("Interact"))
        {
            GetComponent<ThirdPersonController>().CanInteract = true;
        }
    }
    
    // Trigger'dan çıktığında çalışır
    private void OnTriggerExit(Collider otherCollidedObject)
    {
        if (otherCollidedObject.CompareTag("Interact"))
        {
            GetComponent<ThirdPersonController>().CanInteract = false;
        }
    }
}