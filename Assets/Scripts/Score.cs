using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {


    public TextMesh currSco;
    public GameObject ballPref;
    public Transform playerObj;

    GameObject Ball;
    int score;
	
	void Update ()
    {
        Ball = GameObject.FindGameObjectWithTag("Ball");
        currSco.text = "" + score;
     	
	}

    void OntriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            score += 1;
            Destroy(Ball);
            (Instantiate(ballPref, new Vector3(playerObj.transform.position.x + 1, playerObj.transform.position.y, 0), Quaternion.identity) as GameObject).transform.parent = playerObj;
            print("SiReconoscoBall");
        }
    }
}
