using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameSwitch : MonoBehaviour
{
    private GameObject uiManager;
    private UIManager uiManagerScript;

    private GameObject switchObject;

    private bool isStartMiniGame = false;

    //public bool isActive = true;

    private GameObject target;
    private Vector3 targetPosition;

    public GameObject score;
    public GameObject time;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = GameObject.FindGameObjectWithTag("UIManager");
        uiManagerScript = uiManager.GetComponent<UIManager>();

        target = GameObject.FindGameObjectWithTag("Target");
        targetPosition = target.transform.position;

        switchObject = GameObject.FindGameObjectWithTag("Switch");

        score.SetActive(false);
        time.SetActive(false);

        switchObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(switchObject.activeSelf);
        //switchObject.SetActive(isActive);

        if (uiManagerScript.isStoopde == true)
        {
            switchObject.SetActive(true);

            //score.SetActive(false);
            time.SetActive(false);
        }
    }

    public void IsHit(bool hit)
    {
        if (hit)
        {
            uiManagerScript.isStoopde = false;

            target.transform.position = targetPosition;

            isStartMiniGame = true;
            uiManagerScript.isStartMiniGame = isStartMiniGame;

            score.SetActive(true);
            time.SetActive(true);

            switchObject.SetActive(false);
        }
        //switchObject.SetActive(true);

    }
    //public void OnTriggerEnter(Collider other)
    //{
    //    target.transform.position = targetPosition;

    //    isStartMiniGame = true;
    //    uiManagerScript.isStartMiniGame = isStartMiniGame;

    //    score.SetActive(true);
    //    time.SetActive(true);

    //    switchObject.SetActive(false);


    //}
}
