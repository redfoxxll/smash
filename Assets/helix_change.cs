using UnityEngine;
using System.Collections;

public class helix_change : MonoBehaviour {
	public Transform aftercollison;
	public Transform ends;
	//public Transform number;
	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other)
	{

			GameObject.Destroy (transform.parent.gameObject);
			Instantiate (aftercollison, transform.parent.position, transform.parent.rotation);
		    Instantiate (ends, transform.parent.position, transform.parent.rotation);

		}

	void Update () {
		
	}
}
