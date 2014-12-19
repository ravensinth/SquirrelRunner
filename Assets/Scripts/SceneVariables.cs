using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class SceneVariables : MonoBehaviour {

    private static int countTreesInScene = 1;
    private static int TreesCreated = 0;
    private static int TreesCreatedThisStage = 0;
    //public static List<GameObject> TreesInScene = new List<GameObject>();
    public static int Stage;
    public static float GameSpeed { get; private set; }
    public static int Score { get; private set; }

    void Start() {
        SettingsHandler.loadSettings();
        StartGame();
    }

    void Update() { }

    private static void UpdateStage() {
        Stage += 1;
        UpdateSpeed();
    }

    private static void UpdateSpeed() {
        GameSpeed += 1;
    }

    //Object bekommen  um in Array einzufügen und Speed zu aktualisieren
    public static void CreateTree() {
        TreesCreated += 1;
        TreesCreatedThisStage += 1;

        if (TreesCreatedThisStage > 8) {
            UpdateStage();
            TreesCreatedThisStage = 0;
        }
    }
    public static void DeleteTree() {
        countTreesInScene -= 1;
    }

    public static void ResetGame() {
        HandleScore.UpdateHighScore(SceneVariables.Score);
        GameSpeed = SettingsHandler.StartSpeed; ;
        Application.LoadLevel(1);       
    }

    public static void AddScore(int value) {
        Score += Convert.ToInt32(Math.Round((value * GameSpeed)/2));
    }

    private void StartGame() {
        GameSpeed = SettingsHandler.StartSpeed; ;
        countTreesInScene = 1;
        TreesCreated = 0;
        TreesCreatedThisStage = 0;
        Score = 0;
    }
}
