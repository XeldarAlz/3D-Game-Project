using StarterAssets;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public InteractionArea interactionArea;
    public bool CanInteract;
    private StarterAssetsInputs _input;

    private void Start()
    {
        _input = GetComponent<StarterAssetsInputs>();
    }

    private void Update()
    {
        Interaction();
    }

    private void Interaction()
    {
        // Eger alanin icindeysem
        if (CanInteract)
        {
            // Eger etkilesim tusuna bastiysam
            if (_input.interaction)
            {
                ParticleSystem particleSystem = interactionArea.InteractionGameObject.GetComponent<ParticleSystem>();

                if (particleSystem.isPlaying == true)
                {
                    particleSystem.Stop();
                }
                else
                {
                    particleSystem.Play();
                }
            }
        }
            
        _input.interaction = false;
    }
}