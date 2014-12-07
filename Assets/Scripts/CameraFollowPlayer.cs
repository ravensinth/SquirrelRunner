using UnityEngine;
using System.Collections;

public class CameraFollowPlayer : MonoBehaviour {
    public GameObject PlayerToFollow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
        this.transform.position = new Vector3(this.transform.position.x,PlayerToFollow.transform.position.y, this.transform.position.z);
	
	}
}
