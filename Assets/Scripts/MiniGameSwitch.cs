using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameSwitch : MonoBehaviour
{
    private GameObject uiManager;
    private UIManager uiManagerScript;

    private bool isStartMiniGame = false;

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

        score.SetActive(false);
        time.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (uiManagerScript.isStoopde == true)
        {
            this.gameObject.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        target.transform.position = targetPosition;

        isStartMiniGame = true;
        uiManagerScript.isStartMiniGame = isStartMiniGame;

        score.SetActive(true);
        time.SetActive(true);

        this.gameObject.SetActive(false);


    }
}
