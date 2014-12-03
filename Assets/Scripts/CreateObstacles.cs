using UnityEngine;
using System.Collections;

public class CreateObstacles : MonoBehaviour {

    public GameObject Obstacle;
    private float XLeftSide = -1.25f;
    private float XRightSide = 1.25f;
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
        placeObstacle();
    } 

    // Update is called once per frame
    void Update() {
        // Seite mit einbeziehen /Entfernung + Wahrscheinlichkeit

        if (FixedY - getNewestObstacle().transform.position.y >= distanceNextOne) {
            placeObstacle();
        }
        
    }

    void placeObstacle() {
        Instantiate(Obstacle, new Vector3(leftOrRight(), FixedY, Obstacle.transform.position.z), Quaternion.identity);
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

    GameObject getNewestObstacle() {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        GameObject newest = null;
        float newestY = -50;
        foreach (GameObject obstacle in obstacles) {
            if (obstacle.transform.position.y > newestY) {
                newest = obstacle;
                newestY = obstacle.transform.position.y;
            }
        }
        return newest;
    }
}


