using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCreate : MonoBehaviour
{
    public GameObject shotCreate;
    public GameObject shotPrefab;

    public int timeCount = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeCount++;
        if (Input.GetMouseButton(0))
        {
            if (timeCount % 6 == 0)
            {
                GameObject shot = Instantiate(shotPrefab, shotCreate.transform);
                Destroy(shot, 1.0f);
            }
        }
    }
}
