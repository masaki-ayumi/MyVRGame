using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

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
    }
}
