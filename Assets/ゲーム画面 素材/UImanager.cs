using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour {

    public GameObject UsuallyUI;
    public GameObject PlayUI;
    public GameObject MenuUI;
    public GameObject OpenSE;
    public GameObject CloseSE;

    public void NormaltoMenu()
    {
        UsuallyUI.transform.Translate(0,0,0);
        PlayUI.transform.Translate(0, 1000, 0);
        MenuUI.transform.Translate(0, -1000, 0);
        OpenSE.SetActive(true);
        CloseSE.SetActive(false);
    }

    public void MenutoNormal()
    {
        UsuallyUI.transform.Translate(0, 0, 0);
        PlayUI.transform.Translate(0, -1000, 0);
        MenuUI.transform.Translate(0, 1000, 0);
        OpenSE.SetActive(false);
        CloseSE.SetActive(true);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
