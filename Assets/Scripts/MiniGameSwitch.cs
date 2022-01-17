using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameSwitch : MonoBehaviour
{
    private GameObject uiManager;
    private UIManager uiManagerScript;

    private bool isStartMiniGame = false;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = GameObject.FindGameObjectWithTag("UIManager");
        uiManagerScript = uiManager.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        isStartMiniGame = true;
        uiManagerScript.isStartMiniGame = isStartMiniGame;
    }
}
