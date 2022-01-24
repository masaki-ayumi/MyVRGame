using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameStart : MonoBehaviour
{
    
    private MiniGameSwitch parentScript;

    private bool isHit = false;

    // Start is called before the first frame update
    void Start()
    {
        GameObject parent = transform.parent.gameObject;
        parentScript = parent.GetComponent<MiniGameSwitch>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        
        isHit = true;
        parentScript.IsHit(isHit);
        Debug.Log(isHit);
        isHit = false;
        parentScript.IsHit(isHit);

        Debug.Log(isHit);

    }
}
