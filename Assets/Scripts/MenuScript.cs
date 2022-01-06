using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject menuObject;

    GameObject uiManager;
    UIManager uiManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = GameObject.FindGameObjectWithTag("UIManager");
        uiManagerScript = uiManager.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (uiManagerScript.isStoopde)
        {
            menuObject.SetActive(true);
        }
    }
}
