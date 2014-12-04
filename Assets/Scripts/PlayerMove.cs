using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void TouchLeft() {
        this.transform.position = new Vector3(-1.25f, -3, 0);
    }

    void TouchRight() {
        this.transform.position = new Vector3(1.25f, -3, 0);
    }
}


