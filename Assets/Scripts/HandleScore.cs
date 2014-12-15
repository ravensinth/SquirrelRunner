using UnityEngine;
using System.Collections;

public class HandleScore : MonoBehaviour {

	public static void UpdateHighScore (int newScore) {
        if (newScore > PlayerPrefs.GetInt("HighScore")) {
            PlayerPrefs.SetInt("HighScore", newScore);
        }
	}
}
