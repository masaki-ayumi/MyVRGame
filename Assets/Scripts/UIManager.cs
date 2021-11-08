using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    Text scoreText;


    public GameObject target;
    TargetController targetScripts;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = this.GetComponent<Text>();

        targetScripts = target.GetComponent<TargetController>();

    }

    // Update is called once per frame
    void Update()
    {
        score = targetScripts.score;
        scoreText.text = score.ToString();
    }
}
