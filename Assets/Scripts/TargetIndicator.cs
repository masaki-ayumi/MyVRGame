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

        // カメラ後方にあるターゲットのスクリーン座標は、画面中心に対する点対称の座標にする
        if (position.z < 0f)
        {
            position.x = -position.x;
            position.y = -position.y;
        }

        float d = Mathf.Max(
            Mathf.Abs(position.x / position.x),
            Mathf.Abs(position.y / position.y)
        );

        // ターゲットのスクリーン座標が画面外なら、画面端になるよう調整する
        bool isOffscreen = (position.z < 0f || d > 1f);
        if (isOffscreen)
        {
            position.x /= d;
            position.y /= d;
        }

        Debug.Log(position);
        //Debug.Log(mainCamera.WorldToScreenPoint(target.position));
        Debug.Log(centor);

        rectTransform.anchoredPosition = position;
    }
}
