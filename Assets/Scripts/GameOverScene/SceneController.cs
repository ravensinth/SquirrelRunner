﻿using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void RestartGame() {
        Application.LoadLevel("GameScene");
    }
    public void LoadSettingsScene() {
        Application.LoadLevel("SettingsScene");
    }
}
