using UnityEngine;
using System.Collections;

public class diamond_aftercollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
//		InvokeRepeating ("Destroy",2.0f,0.5f);
		InvokeRepeating ("DestroyDetect",2.0f,0.5f);

	}
	void DestroyDetect()
	{
		if(transform.position.z < Camera.main.transform.position.z)
			GameObject.Destroy (transform.gameObject);
	}
	void Destroy()
	{
		GameObject.Destroy (transform.gameObject);
	}
	// Update is called once per frame
	void Update () {
	
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
