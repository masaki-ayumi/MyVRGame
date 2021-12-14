using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
/// <summary>
/// JoyConの状態を画面に表示する
/// </summary>
public class JoyConMonitor : MonoBehaviour
{
    private static readonly Joycon.Button[] buttons =
        Enum.GetValues(typeof(Joycon.Button)) as Joycon.Button[];

    private List<Joycon> joycons;
    private Joycon joyconL;
    private Joycon joyconR;
    private Joycon.Button? pressedButtonL;
    private Joycon.Button? pressedButtonR;


    // Start is called before the first frame update
    void Start()
    {
        joycons = JoyconManager.Instance.j;

        if (joycons == null || joycons.Count <= 0) return;

        joyconL = joycons.Find(c => c.isLeft);
        joyconR = joycons.Find(c => !c.isLeft);
    }

    // Update is called once per frame
    void Update()
    {
        pressedButtonL = null;
        pressedButtonR = null;

        if (joycons == null || joycons.Count <= 0) return;

        foreach(var button in buttons)
        {
            if(joyconL.GetButton(button))
            {
                pressedButtonL = button;
            }

            if (joyconR.GetButton(button))
            {
                pressedButtonR = button;
            }
        }

        if(Input.GetKeyDown(KeyCode.Z))
        {
            joyconL.SetRumble(160, 320, 0.6f, 200);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            joyconR.SetRumble(160, 320, 0.6f, 200);
        }
    }

    private void OnGUI()
    {
        var style = GUI.skin.GetStyle("label");
        style.fontSize = 24;

        if(joycons==null||joycons.Count<=0)
        {
            GUILayout.Label("JoyConが接続できません");
            return;
        }

        if (!joycons.Any(c=>c.isLeft))
        {
            GUILayout.Label("JoyCon(L)が接続されてません");
            return;
        }

        if (!joycons.Any(c => !c.isLeft))
        {
            GUILayout.Label("JoyCon(R)が接続されてません");
            return;
        }

        GUILayout.BeginHorizontal(GUILayout.Width(960));

        foreach(var joycon in joycons)
        {
            var isLeft          = joycon.isLeft;
            var name            =isLeft? "Joy - Con(L)" : "Joy - Con(R)";
            var key             = isLeft ? "Z キー" : "X キー";
            var button          = isLeft ? pressedButtonL : pressedButtonR;
            var stick           = joycon.GetStick();
            var gyro            = joycon.GetGyro();
            var accel           = joycon.GetAccel();
            var orientation     = joycon.GetVector();

            GUILayout.BeginVertical(GUILayout.Width(480));
            GUILayout.Label(name);
            GUILayout.Label(key + "：振動");
            GUILayout.Label("押されているボタン：" + button);
            GUILayout.Label(string.Format("スティック：({0}, {1})", stick[0], stick[1]));
            GUILayout.Label("ジャイロ：" + gyro);
            GUILayout.Label("加速度：" + accel);
            GUILayout.Label("傾き：" + orientation);
            GUILayout.EndVertical();
        }
        GUILayout.EndHorizontal();
    }
}
