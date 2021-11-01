﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    Transform trans;
    Rigidbody rigid;
    Vector3 targetVector;

    // Start is called before the first frame update
    void Start()
    {
        trans = this.GetComponent<Transform>();
        rigid = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    /// <summary>
    /// 弾に当たったら的が移動する
    /// </summary>
    public void OnTriggerEnter(Collider other)
    {
        trans.transform.position = new Vector3(0, 0, 0);
        targetVector = new Vector3(0, 0, 0);

        //座標を乱数で決定
        targetVector.x = Random.Range(-10, 10);
        targetVector.y = Random.Range(-10, 10);
        targetVector.z = Random.Range(-10, 10);

        //新しい座標を代入
        trans.transform.Translate(targetVector);
    }

}