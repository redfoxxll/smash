﻿using UnityEngine;
using System.Collections;

public class cube_change : MonoBehaviour {
	public Transform aftercollison;
	static public bool checkit = false;
	void Start () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		//TODO:update UI counter
		checkit = true;

		GameObject.Destroy(transform.parent.gameObject);
//		gameObject.SetActive (false);
		Instantiate (aftercollison,transform.parent.position,transform.parent.rotation);
	}
	void Update () {
		
	}
}
