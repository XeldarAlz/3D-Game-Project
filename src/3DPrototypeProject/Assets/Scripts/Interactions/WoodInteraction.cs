using UnityEngine;

public class WoodInteraction : InteractionArea
{
    public override void Interact()
    {
        PlayerStates playerStates = FindFirstObjectByType<PlayerStates>();
        playerStates.HaveWood = true;
        playerStates.WoodOnHandGameObject.SetActive(true);
        Destroy(gameObject);
    }
}
