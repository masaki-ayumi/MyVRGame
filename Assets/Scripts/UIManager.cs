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


    TargetController targetScripts;
    private int score = 0;
    private const float TIME = 60f;
    public float countdown = 60f;

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

        GameObject target = GameObject.FindGameObjectWithTag("Target");
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
            TimeUI(isStart);
            ScoreUI(score);
        }
    }

    public void TimeUI(bool isStart)
    {
        countdown -= Time.deltaTime;
        timeText.text = countdown.ToString("f0");
        isStoopde = false;
        Debug.Log(countdown);
        if (countdown < 0)
        {
            timeText.text = "おわり";

            countdown = TIME;

            isStoopde = true;
            isStartMiniGame = false;
        }
    }


    public void ScoreUI(int score)
    {
        //的からスコアを受け取る
        score = targetScripts.score;

        //スコア画面表示
        scoreText.text = "スコア:" + score.ToString();

        //isStoopde = false;
        if (isStoopde)
        {
            targetScripts.score = 0;
        }
    }

    public void MenuUI(bool isStoopde)
    {
        //if (isStoopde)
        //{
        //    menuObject.SetActive(true);
        //}
    }
}
