using UnityEngine;
using System.Collections;

public class CameraFollowPlayer : MonoBehaviour {
    public GameObject PlayerToFollow;
    public float DistanceToPLayer;
    public float smoothTime;
    private float smoothVelocity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
        if (SettingsHandler.SmoothCamera) {
            float tempPosY = Mathf.SmoothDamp(this.transform.position.y, PlayerToFollow.transform.position.y + DistanceToPLayer * 1.2f, ref smoothVelocity, smoothTime);
            this.transform.position = new Vector3(this.transform.position.x, tempPosY, this.transform.position.z);
        }
        else {        
        this.transform.position = new Vector3(this.transform.position.x, PlayerToFollow.transform.position.y + DistanceToPLayer, this.transform.position.z);
        }
	}
}
