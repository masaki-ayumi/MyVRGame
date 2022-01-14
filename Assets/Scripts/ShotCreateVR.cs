using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 弾を生成する
/// </summary>
public class ShotCreateVR : MonoBehaviour
{
    public GameObject shotCreate;
    public GameObject shotPrefab;

    GameObject audioObject;
    AudioScript audioScript;

    EffectScript effectScript;

    GameObject uiIManager;
    UIManager uiManagerScript;

    public int timeCount = 0;



    // Start is called before the first frame update
    void Start()
    {
        effectScript = this.GetComponent<EffectScript>();

        uiIManager = GameObject.FindGameObjectWithTag("UIManager");
        uiManagerScript = uiIManager.GetComponent<UIManager>();

        audioObject = GameObject.FindGameObjectWithTag("Audio");
        audioScript = audioObject.GetComponent<AudioScript>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //JoyConの情報のインスタンスを取得
        var joycons = JoyconManager.Instance.j;
        var joyconR = joycons.Find(c => !c.isLeft); // Joy-Con (R)




        timeCount++;
        //JoyConのZRボタンもしくはマウスの左クリックで発射
        if (Input.GetMouseButton(0) && uiManagerScript.isStoopde == false||
            joyconR.GetButton(Joycon.Button.SHOULDER_2) && uiManagerScript.isStoopde == false)
        {
            //弾発射時にJoyCon振動
            //joyconR.SetRumble(160, 320, 0.6f, 1000);

            //弾を等間隔で発射
            if (timeCount % 6 == 0)
            {
                GameObject shot = Instantiate(shotPrefab, shotCreate.transform);
                Destroy(shot, 1.0f);
                effectScript.MuzzleFlashEffect();
                audioScript.MuzzleFlashSE();

            }
        }
    }
}
