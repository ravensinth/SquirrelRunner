using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayLastScore : MonoBehaviour {

	Text LastScore;
	// Use this for initialization
	void Start () {
        LastScore = this.GetComponent<Text>();
        LastScore.text = "Score: " + SceneVariables.Score;      
	}
	
	// Update is called once per frame
	void Update () {
        	
	}
}


