using UnityEngine;
using System.Collections;

public class cube_change : MonoBehaviour {
	public Transform aftercollison;
	static public bool checkit = false;

	void OnTriggerEnter(Collider other)
	{
		//TODO:update UI counter
		checkit = true;
		GameObject.Destroy(transform.parent.gameObject);
		Instantiate (aftercollison,transform.parent.position,transform.parent.rotation);
	}
}
