using UnityEngine;
using System.Collections;

public class CreateElement : MonoBehaviour {

    public GameObject Element;
    private static float XLeftSide = -1.25f;
    private static float XRightSide = 1.25f;
    public float FixedY;
    public float MaxDistanceToNext;
    public float MinDistanceToNext;
    public float FactorProbablySameSide;
    //Werden genutzt um anzugeben wie oft hintereinander auf der selben Seite gesetzt wurde
    private int consecutiveRight, consecutiveLeft;

    //Wird genutzt um festzuhalten in welcher Entfernung vom letzter der Neue gesetzt werden soll
    private float distanceNextOne;

    // Use this for initialization
    void Start() {
        placeElement();
    }

    // Update is called once per frame
    void Update() {
        if (FixedY - getNewestElement().transform.position.y >= distanceNextOne) {
            placeElement();
        }

    }

    void placeElement() {
        Instantiate(Element, new Vector3(leftOrRight(), FixedY, Element.transform.position.z), Quaternion.identity);
        setDistanceNextOne();
    }
    

    float leftOrRight() {
        float min = 0.0f + consecutiveLeft * FactorProbablySameSide;
        float max = 1.0f - consecutiveRight * FactorProbablySameSide;
        float rand = Random.Range(min, max);
        if (rand < 0.5f) {
            consecutiveLeft++;
            consecutiveRight = 0;
            return XLeftSide;
        }
        else
            consecutiveRight++;
        consecutiveLeft = 0;
        return XRightSide;
    }

    void setDistanceNextOne() {
        distanceNextOne = Random.Range(MinDistanceToNext, MaxDistanceToNext);
    }

    GameObject getNewestElement() {
        GameObject[] collectables = GameObject.FindGameObjectsWithTag(Element.tag);
        GameObject newest = null;
        float newestY = -50;
        foreach (GameObject collectable in collectables) {
            if (collectable.transform.position.y > newestY) {
                newest = collectable;
                newestY = collectable.transform.position.y;
            }
        }
        return newest;
    }
}
