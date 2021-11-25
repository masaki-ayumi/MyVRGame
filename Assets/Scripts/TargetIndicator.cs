using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetIndicator : MonoBehaviour
{
    public Transform target;
    Camera mainCamera;
    RectTransform rectTransform;

    public Image arrow;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;

        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float canvasScale = transform.root.localScale.z;
        var center = 0.5f * new Vector3(Screen.width, Screen.height);

        var position = mainCamera.WorldToScreenPoint(target.position) - center;

        // カメラ後方にあるターゲットのスクリーン座標は、画面中心に対する点対称の座標にする
        if (position.z < 0f)
        {
            position.x = -position.x;
            position.y = -position.y;
        }

        // カメラと水平なターゲットのスクリーン座標を補正する
        if (Mathf.Approximately(position.y, 0f))
        {
            position.y = -center.y;
        }



        var halfSize = 0.5f * canvasScale * rectTransform.sizeDelta;
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


        rectTransform.anchoredPosition = position / canvasScale;


        // ターゲットのスクリーン座標が画面外なら、ターゲットの方向を指す矢印を表示する
        arrow.enabled = isOffscreen;
        if (isOffscreen)
        {
            arrow.rectTransform.eulerAngles = new Vector3(0f, 0f,
                Mathf.Atan2(position.y, position.x) * Mathf.Rad2Deg
            );
        }
    }
}
