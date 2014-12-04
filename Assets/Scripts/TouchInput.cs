using UnityEngine;
using System.Collections;

public class TouchInput : MonoBehaviour {

    public GameObject ControllingInstance;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        // Game Mode 1 
# if UNITY_EDITOR
        //Mouse        
        if (Input.GetMouseButtonDown(0)) {
            if (Input.mousePosition.x < Screen.width / 2) {
                ControllingInstance.SendMessage("TouchLeft");
            }
            else if (Input.mousePosition.x > Screen.width / 2) {
                ControllingInstance.SendMessage("TouchRight");
            }
        }
# endif
        // Touch 
        if (Input.GetTouch(0).position.x < Screen.width / 2) {
            ControllingInstance.SendMessage("TouchLeft");
        }
        else if (Input.GetTouch(0).position.x > Screen.width / 2) {
            ControllingInstance.SendMessage("TouchRight");
        }
    }
}
