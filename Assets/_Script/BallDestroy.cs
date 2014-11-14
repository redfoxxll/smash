using UnityEngine;
using System.Collections;

public class BallDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating ("DestroyDetect",5.0f,0.1f);
	}
	void DestroyDetect()
	{
		if(transform.position.z < Camera.main.transform.position.z)
			GameObject.Destroy (transform.gameObject);
	}
}
