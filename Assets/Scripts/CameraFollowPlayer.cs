using UnityEngine;
using System.Collections;

public class CameraFollowPlayer : MonoBehaviour {
    public GameObject PlayerToFollow;
    public float DistanceToPLayer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
        this.transform.position = new Vector3(this.transform.position.x, PlayerToFollow.transform.position.y + DistanceToPLayer, this.transform.position.z);
	
	}
}
