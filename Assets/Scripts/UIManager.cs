using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// UI関連
/// </summary>
public class UIManager : MonoBehaviour
{
    Text scoreText;
    public GameObject scoreTextobject;

    public GameObject target;
    TargetController targetScripts;
    private int score = 0;
    private float countdown = 60f;

    public bool isStoopde = false;
    public bool isStartMiniGame = false;

    Text timeText;
    public GameObject timeTextobject;

    public GameObject menuObject;

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
        ShootingGame(isStartMiniGame);
        MenuUI(isStoopde);
    }


    public void ShootingGame(bool isStart)
    {
        if (isStart)
        {
            TimeUI(countdown);
            ScoreUI(score);
        }
    }

    public void TimeUI(float countdown)
    {
        countdown -= Time.deltaTime;
        timeText.text = countdown.ToString("f0");
        if (countdown <= 0)
        {
            timeText.text = "おわり";

            isStoopde = true;
        }
    }


    public void ScoreUI(int score)
    {
        //的からスコアを受け取る
        score = targetScripts.score;

        //スコア画面表示
        scoreText.text = "スコア:" + score.ToString();
    }

    public void MenuUI(bool isStoopde)
    {
        //if (isStoopde)
        //{
        //    menuObject.SetActive(true);
        //}
    }
}
