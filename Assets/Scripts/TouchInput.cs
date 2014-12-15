using UnityEngine;
using System.Collections;

public class TouchInput : MonoBehaviour {

    public GameObject ControllingInstance;
    public bool UseControlModeClick, UseControlModeSwype;
    private bool swyping;
    private Vector2 sywpeStart, swypeEnd;

    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        #region  Control Mode Click
        if (UseControlModeClick) {
            // Control Mode 1 
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
            /*
        // Touch 
        if (Input.GetTouch(0).position.x < Screen.width / 2) {
            ControllingInstance.SendMessage("TouchLeft");
        }
        else if (Input.GetTouch(0).position.x > Screen.width / 2) {
            ControllingInstance.SendMessage("TouchRight");
        }
         */
        }
        #endregion

        #region Control Mode Swype
# if UNITY_EDITOR
        //Maus
        if (UseControlModeSwype) {
            // On first Click
            if (Input.GetMouseButtonDown(0)) {
                swyping = true;
                sywpeStart = Input.mousePosition;
            }
            // On holding down
            if (Input.GetMouseButton(0) && swyping) {
                swypeEnd = Input.mousePosition;
            }
            // On letting go swyping Variable momenan niocht nötig 
            if (Input.GetMouseButtonUp(0) && swyping) {

                //Used to minimize an error whemn making very short touches
                int ErrorPotential = Screen.width / 5;
                if (System.Math.Abs(swypeEnd.x - sywpeStart.x) > ErrorPotential) {

                    if (swypeEnd.x - sywpeStart.x > ErrorPotential) {
                        ControllingInstance.SendMessage("SwypeRight");
                    }
                    else if (swypeEnd.x - sywpeStart.x < -ErrorPotential) {
                        ControllingInstance.SendMessage("SwypeLeft");
                    }
                }
                // Ein einfache Klick
                else {
                    ControllingInstance.SendMessage("Click");
                }
            }
        }
#endif
        //Touch
        if (UseControlModeSwype) {
            // On first Click
            if (Input.GetTouch(0).phase == TouchPhase.Began) {
                sywpeStart = Input.GetTouch(0).position;
            }
            // On holding down
            if (Input.GetTouch(0).phase == TouchPhase.Moved) {
                swypeEnd = Input.GetTouch(0).position;
            }
            // On letting go
            if (Input.GetTouch(0).phase == TouchPhase.Ended) {
                //Used to minimize an error whemn making very short touches
                int ErrorPotential = Screen.width / 5;
                if (System.Math.Abs(swypeEnd.x - sywpeStart.x) > ErrorPotential) {

                    if (swypeEnd.x - sywpeStart.x > ErrorPotential) {
                        ControllingInstance.SendMessage("SwypeRight");
                    }
                    else if (swypeEnd.x - sywpeStart.x < -ErrorPotential) {
                        ControllingInstance.SendMessage("SwypeLeft");
                    }
                }
                // Ein einfache Klick
                else {
                    ControllingInstance.SendMessage("Click");
                }
            }
        }
        #endregion



    }
}
