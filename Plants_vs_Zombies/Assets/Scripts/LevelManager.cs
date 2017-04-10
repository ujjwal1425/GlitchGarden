using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

public float auotLoadNextLevel;
	// Use this for initialization
	void Start () {
		Invoke("LoadNextLevel", auotLoadNextLevel);
	}

	public void LoadLevel (string name)
	{
	Application.LoadLevel(name);
	}
	public void QuitRequest ()
	{
	Application.Quit();
	}
	public void LoadNextLevel ()
	{
	Application.LoadLevel(Application.loadedLevel+1);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
