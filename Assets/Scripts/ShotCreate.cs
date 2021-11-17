using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCreate : MonoBehaviour
{
    public GameObject shotCreate;
    public GameObject shotPrefab;

    public EffectScript effectScript;

    public int timeCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        effectScript = this.GetComponent<EffectScript>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeCount++;
        if (Input.GetMouseButton(0))
        {
            effectScript.FireEffect(shotCreate.transform);

            if (timeCount % 6 == 0)
            {
                GameObject shot = Instantiate(shotPrefab, shotCreate.transform);
                Destroy(shot, 1.0f);

            }
        }
    }
}
