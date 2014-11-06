using UnityEngine;
using System.Collections;

public class CameraMoveCarrier : MonoBehaviour {
	public bool cameramove;
	public float cameraspeed;

	// Use this for initialization
	void Start () {
		cameramove = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (cameramove) {
			Debug.Log ("cameramove is"+cameramove);
			transform.Translate (0, 0, cameraspeed * Time.deltaTime);
		}
	}
}
