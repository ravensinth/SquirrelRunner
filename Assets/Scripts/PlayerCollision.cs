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
            SceneVariables.ResetGame();
        }
        if (otherObj.tag == "Collectable") {
            otherObj.SendMessage("EmitParticles");
            Destroy(otherObj.gameObject);
            SceneVariables.AddScore(5);
        }
    }
}
