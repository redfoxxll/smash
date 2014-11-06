using UnityEngine;
using System.Collections;

public class SwithOnTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(Collider other){
		transform.GetComponent<Animator> ().SetBool ("SwithOnToOff",true);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
