using UnityEngine;
using System.Collections;

public class BarBefore : MonoBehaviour {
	public Transform aftercollison;
	void OnTriggerEnter(Collider other)
	{
		//TODO:update UI counter
		
		GameObject.Destroy(transform.parent.gameObject);
		//		gameObject.SetActive (false);
		Instantiate (aftercollison,transform.parent.position,transform.parent.rotation);
	}

//	void OnCollisionEnter(Collision collision)
//	{
//		GameObject.Destroy(transform.parent.gameObject);
//		//		gameObject.SetActive (false);
//		Instantiate (aftercollison,transform.parent.position,transform.parent.rotation);
//	}
}
