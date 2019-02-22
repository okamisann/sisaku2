using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levellevel : MonoBehaviour
{
    private Text LevelUI;
    GameObject unitychan;
    PlayerStatus script;
    int a;
    

    // Use this for initialization
    void Start()
    {
        unitychan = GameObject.Find("unitychan");
        script = unitychan.GetComponent<PlayerStatus>();
        a = script.Level;
    }

    // Update is called once per frame
    void Update()
    {
        //LevelUI.text = a.ToString();
    }
}