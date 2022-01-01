using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// オーディオ関連
/// 音は再生させる関数等
/// </summary>
public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip muzzleFlashSE;
    public AudioClip explosionSE;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //マズルフラッシュ効果音
    public void MuzzleFlashSE()
    {
        audioSource.PlayOneShot(muzzleFlashSE);
    }

    //爆発効果音
    public void ExplosionSE()
    {
        audioSource.PlayOneShot(explosionSE);
    }
}
