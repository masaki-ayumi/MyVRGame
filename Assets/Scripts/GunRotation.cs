using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    List<Joycon> joycons;
    Joycon joyconR;
    Vector3 gyro;
    // Start is called before the first frame update
    void Start()
    {
        joycons = JoyconManager.Instance.j;
        joyconR = joycons.Find(c => !c.isLeft);

        gyro = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        gyro = joyconR.GetGyro();
    }
}
