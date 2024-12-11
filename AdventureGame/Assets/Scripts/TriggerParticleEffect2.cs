using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem),typeof(Collider))]
public class TriggerParticleEffect2 : MonoBehaviour
{
    private ParticleSystem particleSystem; //Reference to the Particle System
    
    public int firstEmissionAmount = 10; // Exposed variable for particle amount
    public int secondEmissionAmount = 20;
    public int thirdEmissionAmount = 30;
    public float delayBetweenEmissions = 0.5f;
    
    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>()) // Check if the player triggered the event
        {
            StartCoroutine(EmitParticlesCoroutine());
        }
    }
    
    // Coroutine to emit particles multiple times with delays
    private IEnumerator EmitParticlesCoroutine()
    {
        // First emission
        particleSystem.Emit(firstEmissionAmount);
        yield return new WaitForSeconds(delayBetweenEmissions); // Wait for specified time
        
        // Second emission
        particleSystem.Emit(secondEmissionAmount);
        yield return new WaitForSeconds(delayBetweenEmissions); // Wait for specified time
        
        // Third emission
        particleSystem.Emit(thirdEmissionAmount);
    }
}
