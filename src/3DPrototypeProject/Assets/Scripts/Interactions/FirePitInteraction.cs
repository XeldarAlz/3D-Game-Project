using UnityEngine;

public class FirePitInteraction : InteractionArea
{
    public override void Interact()
    {
        PlayerStates playerStates = FindFirstObjectByType<PlayerStates>();
        ParticleSystem particleSystem = InteractionGameObject.GetComponent<ParticleSystem>();

        // Ateş yanıyor
        if (particleSystem.isPlaying)
        {
            particleSystem.Stop();
        }
        else // Ateş söndüğünde
        {
            // Eğer odunum varsa
            if (playerStates.HaveWood)
            {
                // Ateşi yak
                particleSystem.Play();
                
                // Odunu kullan, yani odunum artık yok
                playerStates.HaveWood = false;
                playerStates.WoodOnHandGameObject.SetActive(false);
            }
        }
    }
}