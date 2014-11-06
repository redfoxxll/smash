using UnityEngine;
using System.Collections;

public class pyramid_change : MonoBehaviour {
	public Transform aftercollison;
	public Transform number;
	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		//logic for the ball count
		TouchControl.ballnumber += 5;
		TouchControl.ballmodecounter++;
		if (TouchControl.ballmodecounter >= 3) 
		{
			TouchControl.shootingballmode++;	
			TouchControl.ballmodecounter = 0;
		}
		//TODO:update UI counter
		
		Debug.Log ("the total ball num is"+TouchControl.ballnumber);
		GameObject.Destroy(transform.parent.gameObject);
		Instantiate (aftercollison,transform.parent.position,transform.parent.rotation);
//		Debug.Log ("the pos of py is "+transform.position);
		Transform tmp = (Transform)Instantiate (number,transform.position+new Vector3(0,5,-2),number.rotation);
//		tmp
		Debug.Log ("the pos of tmp is "+tmp.position);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
