using UnityEngine;
using System.Collections;

public class PlayerMove2 : MonoBehaviour {


    private float GameSpeed = SceneVariables.GameSpeed;
    public float BoostDuration;
    public float BoostPower;
    public float BoostVelocity;
    bool boostActive;
    float boostSpeed;
    private bool UseControlModeClick, UseControlModeSwype;
    void Start() {
        boostSpeed = GameSpeed;
    }

    // Update is called once per frame
    void Update() {
        GameSpeed = SceneVariables.GameSpeed;
        Vector3 moveObject = Vector3.up;

        boostSpeed = getBoostSpeed();
        //Debug.Log(boostSpeed);

        this.transform.position += moveObject * boostSpeed * Time.deltaTime;
    }

    #region Control Mode Click
    void TouchLeft() {
        if (this.transform.position.x == -1.25f) {
            activateBoost();
        }
        else {
            SetPlayerLeft();
        }
    }

    void TouchRight() {
        if (this.transform.position.x == 1.25f) {
            activateBoost();
        }
        else {
            SetPlayerRight();
        }
    }

    #endregion

    #region Control Mode Swype

    void Click() {
        activateBoost();
    }

    void SwypeLeft() {
        SetPlayerLeft();
    }

    void SwypeRight() {
        SetPlayerRight();
    }
#endregion
    void SetPlayerLeft() {
        this.transform.position = new Vector3(-1.25f, this.transform.position.y, 0);
    }

    void SetPlayerRight() {
        this.transform.position = new Vector3(1.25f, this.transform.position.y, 0);
    }

    void activateBoost() {
        boostSpeed = boostSpeed + BoostPower;
        //GameSpeed statt boostSpeed einsetzen für leicht anderen Modus
    }

    float getBoostSpeed() {
        return Mathf.SmoothDamp(boostSpeed, GameSpeed, ref BoostVelocity, BoostDuration, Mathf.Infinity, Time.deltaTime);
    }
}

