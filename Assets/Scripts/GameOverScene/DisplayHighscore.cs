using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayHighscore : MonoBehaviour {
    Text HighScore;
    // Use this for initialization
    void Start() {
        HighScore = this.GetComponent<Text>();
        HighScore.text = "Your current Highscore: " + PlayerPrefs.GetInt("HighScore").ToString();            
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
