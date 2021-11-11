using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetIndicator : MonoBehaviour
{
    public Transform target;
    Camera mainCamera;
    RectTransform rectTransform;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;

        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        var centor = 0.5f * new Vector3(Screen.width, Screen.height);

        var position = mainCamera.WorldToScreenPoint(target.position) - centor;

        rectTransform.anchoredPosition = position;
    }
}
