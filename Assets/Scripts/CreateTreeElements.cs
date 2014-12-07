using UnityEngine;
using System.Collections;

public class CreateTreeElements : MonoBehaviour {
    public GameObject TreeElement;
    private bool IsNextElementInScene = false;
    private GameObject player;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        SceneVariables.CreateTree();
    }

    void CreateNextTreeElement() {
        Debug.Log(this.renderer.bounds.max.y);
        Instantiate(TreeElement, new Vector3(this.transform.position.x, this.transform.position.y + (this.renderer.bounds.max.y - this.renderer.bounds.min.y), this.transform.position.z), Quaternion.identity);
        SceneVariables.AddScore(1);
    }

    // Update is called once per frame
    void Update() {
        if (this.transform.position.y - player.transform.position.y < 20 & IsNextElementInScene == false) {
            IsNextElementInScene = true;
            CreateNextTreeElement();

        }
    }
}
