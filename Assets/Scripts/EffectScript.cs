using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectScript : MonoBehaviour
{
    ParticleSystem particle;
    public GameObject muzzleFlashEffect;
    public GameObject explosionEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //マズルフラッシュエフェクト
    public void MuzzleFlashEffect()
    {
        particle = muzzleFlashEffect.GetComponent<ParticleSystem>();

        particle.Play();
    }

    //爆発エフェクト
    public void ExplosionEffect()
    {
        particle = explosionEffect.GetComponent<ParticleSystem>();

        particle.Play();
    }
}
