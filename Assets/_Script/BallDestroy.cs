using UnityEngine;
using System.Collections;

public class BallDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating ("DestroyBall",5.0f,0.5f);
	}
	void DestroyBall()
	{
		GameObject.Destroy (transform.gameObject);
	}
}
