using UnityEngine;
using System.Collections;

public class DoorCircle : MonoBehaviour {
	void OnTriggerEnter(Collider other){
		transform.GetComponent<MeshCollider> ().enabled = false;
	}
	void OnTriggerExit(Collider other){
		transform.GetComponent<MeshCollider> ().enabled = true;
	}
}
