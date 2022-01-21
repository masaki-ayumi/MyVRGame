using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
/// <summary>
/// 
/// </summary>
public class DoTweenScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.DORotate(new Vector3(180f, 0, 0), 2f).SetLoops(-1,LoopType.Restart);
    }
}
