using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddie : MonoBehaviour {

    public float paddleSpeed = 1f;
    public Vector3 playerpos = new Vector3 (0,0,0); 
	
	
	void Update () {

        float ypos = gameObject.transform.position.y + (Input.GetAxis("Vertical") * paddleSpeed );
        playerpos = new Vector3(-8,Mathf.Clamp(ypos, -4,4),0);
        gameObject.transform.position = playerpos; 
		
	}
}
