using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButton(0)) {
            this.transform.position = new Vector3(1.25f, -3, 0);
        }
        else if (Input.GetMouseButton(1)) {
            this.transform.position = new Vector3(-1.25f, -3, 0);
        }

    }
    void OnTriggerEnter2D(Collider2D otherObj) {
        if (otherObj.tag == "Obstacle") {
            //  Menü
            Application.LoadLevel(0);
            SceneVariables.ResetGame();
            Debug.Log("CollisionObs");
        }
        if (otherObj.tag == "Collectable") {
            Destroy(otherObj.gameObject);
            Debug.Log("CollisionCol");
        }
    }
    void OnCollisionEnter2D(Collision2D coll) {
        Debug.Log("Collision");
    }


}


