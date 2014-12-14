using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {
    Text Score;
	// Use this for initialization
	void Start () {
        Score = this.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        Score.text = "Score: " + SceneVariables.Score;	
	}
}
