using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 8;
    Vector3 targetPos;
    Vector3 playepos;
    GameObject ballObj; 
    
	void Start ()
    {

        ballObj = GameObject.FindGameObjectWithTag("Ball");
		
	}
	
	
	void Update () {

        targetPos = Vector3.Lerp(gameObject.transform.position, ballObj.transform.position, Time.deltaTime * speed);
        playepos = new Vector3(-8, Mathf.Clamp(targetPos.y, -4, 4), 0);
        gameObject.transform.position = new Vector3(8,playepos.y,0);

	}
}
