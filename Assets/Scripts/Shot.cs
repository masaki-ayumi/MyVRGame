using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    Rigidbody shotRigidbody;
    float speed = 300f;
    // Start is called before the first frame update
    void Start()
    {
        shotRigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //speed = speed * Time.deltaTime;
        //rigidbody.velocity = transform.forward * speed;
        //rigidbody.velocity = vector;
        shotRigidbody.AddForce(transform.forward * speed);



    }
}

