using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCreate : MonoBehaviour
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
        timeCount++;
        //JoyConのZRボタンもしくはマウスの左クリックで発射
        if (Input.GetKey(KeyCode.JoystickButton15) && uiManagerScript.isStoopde == false ||
            Input.GetMouseButton(0) && uiManagerScript.isStoopde == false)
        {
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
