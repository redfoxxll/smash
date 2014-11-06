using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	public float cameraspeed;
	// Use this for initialization
//	private bool cameramove;
	void Start () {
//		cameramove = false;
//		rigidbody.velocity = new Vector3 (0,0,cameraspeed);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			transform.GetComponent<Animator>().SetTrigger("cameraenterscene");
				}
//		if (cameramove) {
//			Debug.Log ("cameramove is"+cameramove);
//			transform.Translate (0, 0, cameraspeed * Time.deltaTime);
//			}
	}
	public void SetMove(){
		transform.parent.GetComponent<CameraMoveCarrier>().cameramove = true;
//		transform.Find ("smash-hit-banner").gameObject.SetActive(false);
		Debug.Log ("set camera true");
	}
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("collision");
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
