using UnityEngine;
using System.Collections;

public class DoorCircle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		transform.GetComponent<BoxCollider> ().enabled = false;
	}
	void OnTriggerExit(Collider other){
		transform.GetComponent<BoxCollider> ().enabled = true;
	}
}
