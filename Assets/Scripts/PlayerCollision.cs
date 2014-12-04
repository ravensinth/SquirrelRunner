using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D otherObj) {
        if (otherObj.tag == "Obstacle") {
            Application.LoadLevel(0);
            SceneVariables.ResetGame();
            Debug.Log("CollisionObs");
        }
        if (otherObj.tag == "Collectable") {
            Destroy(otherObj.gameObject);
            Debug.Log("CollisionCol");
            SceneVariables.AddScore(5);
        }
    }
}
