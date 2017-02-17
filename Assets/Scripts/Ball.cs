using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float ballSpeed = 300f;
    Rigidbody rb;
    bool ixplay;
    int rantInt;

    void Awake () {
        rb = gameObject.GetComponent<Rigidbody>();
        rantInt = Random.Range(1, 3);
	}
	

	void Update () {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButton(0) == true && ixplay == false)
        {
            print("Funciona");
            transform.parent = null;
            ixplay = true;
            rb.isKinematic = false;
            if (rantInt == 1)
                {
                rb.AddForce(new Vector3(ballSpeed,ballSpeed,0));
            }
            if (rantInt == 2)
                {
                rb.AddForce(new Vector3(ballSpeed, ballSpeed, 0));
            }            
        }
	}
}
