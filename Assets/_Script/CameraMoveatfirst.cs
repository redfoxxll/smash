using UnityEngine;
using System.Collections;

public class CameraMoveatfirst : MonoBehaviour {
	public float cameraspeed;
	void Start () {
//		transform.parent.GetComponent<CameraMoveCarrier>().cameramove = true;
	}
	void Update () {
	//	if (Input.GetMouseButtonDown (0)) 
	//		transform.GetComponent<Animator>().SetTrigger("cameraenterscene");
	}
	//public void SetMove(){
	//	transform.parent.GetComponent<CameraMoveCarrier>().cameramove = true;
	//}
	void OnTriggerEnter(Collider other)
	{
		//logic for the ball count
		TouchControl.ballnumber -= 10;
		TouchControl.ballmodecounter = 0;
		TouchControl.shootingballmode = 1;
		if (TouchControl.ballnumber <= 0) 
		{
			//TODO:UI counter set to 0 game over
			//TODO:camera slow down speed to 0
			Debug.Log("game over");		
		}
		transform.parent.gameObject.GetComponent<Animator> ().SetTrigger ("shake");
	}
}
