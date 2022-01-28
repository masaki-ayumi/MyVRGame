using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 的の動きや状態を制御する
/// </summary>
public class TargetController : MonoBehaviour
{
    Transform trans;
    Rigidbody rigid;
    Vector3 targetVector;

    Transform player;

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

        GameObject mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        player = mainCamera.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //原点を向き続ける
        transform.LookAt(player.transform);
        transform.rotation *= Quaternion.Euler(90f, 0f, 0f);

       
    }



    public void OnTriggerEnter(Collider other)
    {
        //エフェクト再生
        effectScript.ExplosionEffect();

        // 弾に当たったら的が移動する
        count++;
        if (count >= 10)
        {
            
            audioScript.ExplosionSE();

            count = 0;

            trans.transform.position = new Vector3(0, 0, 0);
            targetVector = new Vector3(0, 0, 0);

            //座標を乱数で決定
            targetVector.x = Random.Range(-15, 15);
            targetVector.y = Random.Range(0, 15);
            targetVector.z = Random.Range(-15, 15);

            //新しい座標を代入
            trans.transform.position = targetVector;

            //スコア加算
            score += 1;
        }
    }

}
