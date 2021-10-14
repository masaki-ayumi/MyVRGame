using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    Rigidbody rigidbody;
    Vector3 vector;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        vector = new Vector3(0.0f, 0.0f, 100.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody.AddForce(vector);

        }


    }




}

