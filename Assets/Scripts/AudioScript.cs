using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip fireSE;
    public AudioClip hitSE;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireSE()
    {
        audioSource.PlayOneShot(fireSE);
    }

    public void HitSE()
    {
        audioSource.PlayOneShot(hitSE);
    }
}
