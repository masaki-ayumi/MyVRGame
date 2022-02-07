using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VRModeChange()
    {
        SceneManager.LoadScene("VRMode");
    }

    public void SmartphoneModeChange()
    {
        SceneManager.LoadScene("SmartphoneMode");
    }

    public void TitleSceneChange()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void OnTriggerEnter(Collider other)
    {
        TitleSceneChange();
    }
}
