using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    Text scoreText;
    public GameObject scoreTextobject;

    public GameObject target;
    TargetController targetScripts;
    private int score;
    private float countdown = 60f;

    Text timeText;
    public GameObject timeTextobject;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = scoreTextobject.GetComponent<Text>();

        timeText = timeTextobject.GetComponent<Text>();

        targetScripts = target.GetComponent<TargetController>();

    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        timeText.text = countdown.ToString("f0");
        if (countdown<=0)
        {
            timeText.text = "おわり";
        }

        ScoreUI();
    }

    public void ScoreUI()
    {
        //的からスコアを受け取る
        score = targetScripts.score;

        //スコア画面表示
        scoreText.text = "スコア:"+score.ToString();
    }

    
}
