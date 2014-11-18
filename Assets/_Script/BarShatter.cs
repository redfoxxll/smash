using UnityEngine;
using System.Collections;

public class BarShatter : MonoBehaviour {
	void OnCollisionEnter(Collision collision)
	{
//			transform.rigidbody.useGravity = true;
//		    foreach (Transform child in transform) {
		transform.rigidbody.useGravity = true;
		transform.rigidbody.AddForce (new Vector3 (0, 0, 2), ForceMode.VelocityChange);
//			}
	}
}
