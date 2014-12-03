using UnityEngine;
using System.Collections;
//using System.Collections.Generic;

public class MoveObstacle : MonoBehaviour {
    private float GameSpeed = SceneVariables.GameSpeed;
    void Start() {

    }
	
	// Update is called once per frame
	void Update () {
        GameSpeed = SceneVariables.GameSpeed;
        Vector3 moveObject = Vector3.down;
        this.transform.position += moveObject * GameSpeed * Time.deltaTime;

        if (this.transform.position.y < -50) {
            SceneVariables.DeleteTree();
            Destroy(this.gameObject);
        }
	}
}
