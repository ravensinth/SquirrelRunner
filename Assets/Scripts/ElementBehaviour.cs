using UnityEngine;
using System.Collections;
//using System.Collections.Generic;

public class ElementBehaviour : MonoBehaviour {
    private GameObject player;
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update() {
        if (this.transform.position.y + 20 < player.transform.position.y){
            Destroy(this.gameObject);
        }
    }
}
