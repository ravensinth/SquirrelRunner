using UnityEngine;
using System.Collections;

public class SettingsHandler : MonoBehaviour {

    public static bool UseControlModeSwype { get; private set; }
    public static bool UseControlModeClick { get; private set; }
    public static bool SmoothCamera { get; private set; }
    public static int StartSpeed { get; private set; }
    public static bool ParticlesOnBoost { get; private set; }
    public static bool ParticlesFollowSwype { get; private set; }

	// Use this for initialization
	void Start () {
        //Load Settings
        UseControlModeSwype = bool.Parse(PlayerPrefs.GetInt("UseControlModeSwype").ToString());
        UseControlModeClick = bool.Parse(PlayerPrefs.GetInt("UseControlModeClick").ToString());
        SmoothCamera = bool.Parse(PlayerPrefs.GetInt("SmoothCamera").ToString());
        StartSpeed = PlayerPrefs.GetInt("SmoothCamera");
        ParticlesOnBoost = bool.Parse(PlayerPrefs.GetInt("ParticlesOnBoost").ToString());
        ParticlesFollowSwype = bool.Parse(PlayerPrefs.GetInt("ParticlesFollowSwype").ToString());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
