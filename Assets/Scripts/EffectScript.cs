using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectScript : MonoBehaviour
{
    ParticleSystem particle;
    public GameObject fireEffect;
    public GameObject hitEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FireEffect()
    {
        particle = fireEffect.GetComponent<ParticleSystem>();

        particle.Play();

        if(particle.isStopped)
        {
            particle.Stop();
            Destroy(particle);
        }
    }

    public void HitEffect()
    {
        particle = hitEffect.GetComponent<ParticleSystem>();

        particle.Play();

        if (particle.isStopped)
        {
            particle.Stop();
            Destroy(particle);
        }
    }
}
