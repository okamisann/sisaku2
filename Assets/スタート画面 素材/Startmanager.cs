using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startmanager : MonoBehaviour {

    public void Gamestart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Gameend()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
