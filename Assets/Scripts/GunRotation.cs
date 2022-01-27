using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    List<Joycon> joycons;
    Joycon joyconR;
    Vector3 gyro;
    Quaternion orientation;
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
        const float MOVE_PER_CLOCK = 0.01f;
        gyro = joyconR.GetGyro();
        orientation = joyconR.GetVector();

       

        orientation = Quaternion.Euler(-gyro[1], gyro[2], -gyro[0]);

        gameObject.transform.rotation = transform.rotation * orientation;

        //上ボタンで傾きをリセット
        if (joyconR.GetButton(Joycon.Button.DPAD_UP))
        {
            gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }
}
