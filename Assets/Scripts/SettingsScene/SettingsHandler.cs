using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class SettingsHandler : MonoBehaviour {

    public Toggle UseControlModeSwypeToggle;
    public Toggle UseControlModeClickToggle;
    public Toggle SmoothCameraToggle;
    public Toggle ParticlesOnBoostToggle;
    public Toggle ParticlesFollowSwypeToggle;

    public Slider StartSpeedSlider;

    public static bool UseControlModeSwype { get; private set; }
    public static bool UseControlModeClick { get; private set; }
    public static bool SmoothCamera { get; private set; }    
    public static bool ParticlesOnBoost { get; private set; }
    public static bool ParticlesFollowSwype { get; private set; }

    public static int StartSpeed { get; private set; }

	// Use this for initialization
	void Start () {
        loadSettings();
        displaySettings();        
	}
	
	// Update is called once per frame
	void Update () {
        UseControlModeSwype = UseControlModeSwypeToggle.isOn;
        UseControlModeClick = UseControlModeClickToggle.isOn;
        SmoothCamera = SmoothCameraToggle.isOn;
        ParticlesOnBoost = ParticlesOnBoostToggle.isOn;
        ParticlesFollowSwype = ParticlesFollowSwypeToggle.isOn;

        StartSpeed = Convert.ToInt32(StartSpeedSlider.value);
        //Debug.Log("Update Speed: " + StartSpeed);
	}

    void loadSettings() {
        UseControlModeSwype = Convert.ToBoolean(PlayerPrefs.GetInt("UseControlModeSwype"));
        UseControlModeClick = Convert.ToBoolean(PlayerPrefs.GetInt("UseControlModeClick"));
        SmoothCamera = Convert.ToBoolean(PlayerPrefs.GetInt("SmoothCamera"));        
        ParticlesOnBoost = Convert.ToBoolean(PlayerPrefs.GetInt("ParticlesOnBoost"));
        ParticlesFollowSwype = Convert.ToBoolean(PlayerPrefs.GetInt("ParticlesFollowSwype"));
            
        StartSpeed = PlayerPrefs.GetInt("StartSpeed");
        //Debug.Log("loadSettings Speed: " + StartSpeed);
    }

    void displaySettings() {
        UseControlModeSwypeToggle.isOn = UseControlModeSwype;
        UseControlModeClickToggle.isOn = UseControlModeClick;
        SmoothCameraToggle.isOn = SmoothCamera;
        ParticlesOnBoostToggle.isOn = ParticlesOnBoost;
        ParticlesFollowSwypeToggle.isOn = ParticlesFollowSwype;

        StartSpeedSlider.value = StartSpeed;
        //Debug.Log("displaySettings Speed: " + StartSpeed);
    }

    void saveSettings() {
        PlayerPrefs.SetInt("UseControlModeSwype", Convert.ToInt32(UseControlModeSwype));
        PlayerPrefs.SetInt("UseControlModeClick", Convert.ToInt32(UseControlModeClick));
        PlayerPrefs.SetInt("SmoothCamera", Convert.ToInt32(SmoothCamera));
        PlayerPrefs.SetInt("ParticlesOnBoost", Convert.ToInt32(ParticlesOnBoost));
        PlayerPrefs.SetInt("ParticlesFollowSwype", Convert.ToInt32(ParticlesFollowSwype));

        PlayerPrefs.SetInt("StartSpeed",StartSpeed);
        //Debug.Log("saveSettings Speed: " + StartSpeed);
    }

    public void StartGame() {
        saveSettings();
        Application.LoadLevel(0);
    }


}
