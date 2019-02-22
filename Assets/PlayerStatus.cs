using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour {

    public int Level = 1;

    public int Max_HP;
    public int HP;

    public int Max_SP = 100;
    public int SP;

    public int Str = 1;
    public int Int = 1;

    public int Def = 1;
    public int MDef = 1;

    public int Luck;
    public int Cap;

    // Use this for initialization
    void Start () {

        Max_HP = (Def + MDef) * 25 + Level * 10 + 100;
        HP = Max_HP;

    }
	
	// Update is called once per frame
	void Update () {

        Max_HP = (Def + MDef) * 25 + Level * 10 + 100;
        Debug.Log(Max_HP);

        if (HP > 0)
        {
            HP = HP - 1;
        }
        else
        {
            HP = 0;
            Debug.Log("ちにました／(^o^)＼");
            //コンテニュー画面表示の表示
        }
    }
}
