using UnityEngine;
using System.Collections;

public class CreateTreeElements : MonoBehaviour {
    public GameObject TreeElement;
    private bool IsNextElementInScene = false;

    void Start() {
        SceneVariables.CreateTree();
    }

    void CreateNextTreeElement() {
        Instantiate(TreeElement, new Vector3(this.transform.position.x, this.transform.position.y + 9, this.transform.position.z), Quaternion.identity);
        SceneVariables.AddScore(1);
    }

    // Update is called once per frame
    void Update() {
        if (this.transform.position.y < 50 & IsNextElementInScene == false) {
            IsNextElementInScene = true;
            CreateNextTreeElement();

        }
    }
}
