using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    private float GameSpeed = SceneVariables.GameSpeed;
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        GameSpeed = SceneVariables.GameSpeed;
        Vector3 moveObject = Vector3.up;
        this.transform.position += moveObject * GameSpeed * Time.deltaTime;
    }

    void TouchLeft() {
        this.transform.position = new Vector3(-1.25f, this.transform.position.y, 0);
    }

    void TouchRight() {
        this.transform.position = new Vector3(1.25f, this.transform.position.y, 0);
    }
}


