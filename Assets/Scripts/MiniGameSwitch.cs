using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameSwitch : MonoBehaviour
{
    private GameObject uiManager;
    private UIManager uiManagerScript;

    private bool isStartMiniGame = false;

    public GameObject score;
    public GameObject time;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = GameObject.FindGameObjectWithTag("UIManager");
        uiManagerScript = uiManager.GetComponent<UIManager>();

        score.SetActive(false);
        time.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        isStartMiniGame = true;
        uiManagerScript.isStartMiniGame = isStartMiniGame;

        score.SetActive(true);
        time.SetActive(true);
    }
}
