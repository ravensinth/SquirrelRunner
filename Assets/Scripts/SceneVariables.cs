using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SceneVariables : MonoBehaviour {

    private static float StandardGameSpeed = 4;
    private static int countTreesInScene = 1;
    private static int TreesCreated = 0;
    private static int TreesCreatedThisStage = 0;
    //public static List<GameObject> TreesInScene = new List<GameObject>();
    public static int Stage;
    public static float GameSpeed { get; private set; }
    public static int Score { get; private set; }

    void Start() {
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
        Application.LoadLevel(1);
        //GameSpeed = StandardGameSpeed;
        //countTreesInScene = 1;
        //TreesCreated = 0;
        //TreesCreatedThisStage = 0;
        //Score = 0;
    }

    public static void AddScore(int value) {
        Score += value;
    }

    private void StartGame() {
        GameSpeed = StandardGameSpeed;
        countTreesInScene = 1;
        TreesCreated = 0;
        TreesCreatedThisStage = 0;
        Score = 0;
    }
}
