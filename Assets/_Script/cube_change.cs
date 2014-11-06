using UnityEngine;
using System.Collections;

public class cube_change : MonoBehaviour {
	public Transform aftercollison;
	void Start () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		//TODO:update UI counter

		GameObject.Destroy(transform.parent.gameObject);
		Instantiate (aftercollison,transform.parent.position,transform.parent.rotation);
	}
	void Update () {
		
	}
}
