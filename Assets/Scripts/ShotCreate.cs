using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCreate : MonoBehaviour
{
    public GameObject shotCreate;
    public GameObject shotPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject shot = Instantiate(shotPrefab, shotCreate.transform);
            Destroy(shot, 1.0f);
        }
    }
}
