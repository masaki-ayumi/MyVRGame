using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectScript : MonoBehaviour
{
    ParticleSystem particle;
    public GameObject particleObject;
    // Start is called before the first frame update
    void Start()
    {
        particle = particleObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FireEffect(Transform shotCreate)
    {
        //particle = particleObject.GetComponent<ParticleSystem>();

        GameObject effect = Instantiate(particleObject, shotCreate.position, Quaternion.identity);



        if(particle.isStopped)
        {
            Destroy(effect);

        }



    }
}
