
using UnityEngine;
using System.Collections;

public class contlloler : MonoBehaviour
{

    Quaternion currentGyro;

    void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update()
    {
        currentGyro = Input.gyro.attitude;
        this.transform.localRotation =
            Quaternion.Euler(90, 90, 0) * (new Quaternion(-currentGyro.x, -currentGyro.y, currentGyro.z, currentGyro.w));
    }
}