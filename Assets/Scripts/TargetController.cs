using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 的の動きや状態を制御するスクリプト
/// </summary>
public class TargetController : MonoBehaviour
{
    Transform trans;
    Rigidbody rigid;
    Vector3 targetVector;
    int count = 0;
    public int score = 0;

    public GameObject audioObject;
    AudioScript audioScript;

    EffectScript effectScript;

    // Start is called before the first frame update
    void Start()
    {
        trans = this.GetComponent<Transform>();
        rigid = this.GetComponent<Rigidbody>();

        effectScript = this.GetComponent<EffectScript>();
        audioScript = audioObject.GetComponent<AudioScript>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }



    public void OnTriggerEnter(Collider other)
    {
        //エフェクト再生
        effectScript.ExplosionEffect();

        // 弾に当たったら的が移動する
        count++;
        if (count >= 10)
        {
            

            audioScript.HitSE();

            count = 0;

            trans.transform.position = new Vector3(0, 0, 0);
            targetVector = new Vector3(0, 0, 0);

            //座標を乱数で決定
            targetVector.x = Random.Range(-10, 10);
            targetVector.y = Random.Range(0, 10);
            targetVector.z = Random.Range(-10, 10);

            //新しい座標を代入
            trans.transform.Translate(targetVector);

            //スコア加算
            score += 1;
        }
    }

}
