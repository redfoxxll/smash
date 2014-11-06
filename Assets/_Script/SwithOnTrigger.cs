using UnityEngine;
using System.Collections;

public class SwithOnTrigger : MonoBehaviour {
	void Start () {
	
	}
	void OnTriggerEnter(Collider other){
		transform.GetComponent<Animator> ().SetBool ("SwithOnToOff",true);
	}
	void Update () {
	
	}
}
