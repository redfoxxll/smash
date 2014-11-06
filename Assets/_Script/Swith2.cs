using UnityEngine;
using System.Collections;

public class Swith2 : MonoBehaviour {
	void Start () {
	
	}
	void OnTriggerEnter(Collider other){
		transform.GetComponent<Animator> ().SetBool ("SwithOnToOff",true);

		if(transform.tag == "leftswitch")
		transform.parent.GetComponent<Animator> ().SetBool ("LeftSwithOnToOff",true);
		else if(transform.tag == "rightswitch")
		transform.parent.GetComponent<Animator> ().SetBool ("RightSwithOnToOff",true);
	}
	void Update () {
	
	}
}
