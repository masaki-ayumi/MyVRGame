using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    Text scoreText;
    public GameObject textObject;

    public GameObject target;
    TargetController targetScripts;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = textObject.GetComponent<Text>();

        targetScripts = target.GetComponent<TargetController>();

    }

    // Update is called once per frame
    void Update()
    {
        //的からスコアを受け取る
        score = targetScripts.score;

        //スコア画面表示
        scoreText.text = score.ToString();
    }
}
