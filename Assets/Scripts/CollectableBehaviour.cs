using UnityEngine;
using System.Collections;

public class CollectableBehaviour : MonoBehaviour {
    public ParticleSystem ParticleOnCollect;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D otherObj) {
        if (otherObj.tag == "Obstacle") {
            Destroy(this.gameObject);
        }
    }

    void EmitParticles() {
        Instantiate(ParticleOnCollect, this.transform.position, this.transform.rotation);
    }


}
