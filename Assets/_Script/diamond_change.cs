﻿using UnityEngine;
using System.Collections;

public class diamond_change : MonoBehaviour {
	public Transform aftercollison;
	public Transform number;
	void Start () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		//logic for the ball count
		TouchControl.ballnumber += 5;
		TouchControl.ballmodecounter++;
		if (TouchControl.ballmodecounter >= 10) 
		{
			TouchControl.shootingballmode++;	
			TouchControl.ballmodecounter = 0;
		}
		//TODO:update UI counter

		Debug.Log ("the total ball num is"+TouchControl.ballnumber);
		GameObject.Destroy(transform.parent.gameObject);
		Instantiate (aftercollison,transform.parent.position,transform.parent.rotation);
		Instantiate (number,transform.position+new Vector3(0,1.5f,-1.5f),number.rotation);
	}
	void Update () {
	
	}
}
