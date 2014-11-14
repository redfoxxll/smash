using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	public Transform crashball;

	public float cameraspeed;
	private bool movable;
	void Start () {
		movable = true;
	}
	void Update () {
		if (Input.GetMouseButtonDown (0)&&!TouchControl.touchable) 
			transform.GetComponent<Animator>().SetTrigger("cameraenterscene");
	}
	public void SetMove(){
		transform.parent.GetComponent<CameraMoveCarrier>().cameramove = true;
		TouchControl.touchable = true;
	}
	void OnTriggerEnter(Collider other)
	{
		if (!movable)
			return;
		//logic for the ball count
		movable = false;
		TouchControl.ballnumber -= 10;
		TouchControl.ballmodecounter = 0;
		TouchControl.shootingballmode = 1;
		GameObject.Find ("BallCalc").GetComponent<BallCalc>().BallCalcChange(0);
		if (TouchControl.ballnumber <= 0) 
		{
			//TODO:UI counter set to 0 game over
			//TODO:camera slow down speed to 0
			Debug.Log("game over");		
		}
		transform.parent.gameObject.GetComponent<Animator> ().SetTrigger ("shake");
		Transform crashballtmp = (Transform)Instantiate (crashball,transform.position,transform.rotation);
		foreach (Transform ballchild in crashballtmp) 
		{
			ballchild.rigidbody.AddForce(new Vector3(0,0,10),ForceMode.VelocityChange);		
		}
		Invoke ("SetMovable", 2.0f);
	}
	void SetMovable()
	{
		movable = true;
	}
}
