using UnityEngine;
using System.Collections;

public class BarShatter : MonoBehaviour {

	void Start () {
		InvokeRepeating ("Destroy",5.0f,0.5f);
	}
	void Destroy()
	{
		GameObject.Destroy (transform.gameObject);
	}
	
	void OnCollisionEnter(Collision collision)
	{
		//		if (collision.transform.gameObject.layer == 8) 
		{
			transform.rigidbody.useGravity = true;
			rigidbody.AddForce (new Vector3 (0, 0, 1), ForceMode.VelocityChange);
		}
	}
}
