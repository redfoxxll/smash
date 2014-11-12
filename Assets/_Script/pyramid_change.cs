using UnityEngine;
using System.Collections;

public class pyramid_change : MonoBehaviour {
	public Transform aftercollison;
	public Transform number;

	public static bool checkit;

	void Start () {
		InvokeRepeating ("checkpos",0.5f,0.5f);
	}

	void checkpos()
	{
		if (transform.position.z < Camera.main.transform.position.z) {
			//TODO:UI change
			TouchControl.shootingballmode = 1;
			TouchControl.ballmodecounter = 0;
			GameObject.Find ("BallCalc").GetComponent<BallCalc>().BallCalcChange(0);
			GameObject.Destroy(transform.parent.gameObject);
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		//logic for the ball count
//		BallCalc.BallCalcChange ();
		pyramid_change.checkit = true;
		TouchControl.ballnumber += 3;
		if (TouchControl.shootingballmode < 5) {
						TouchControl.ballmodecounter++;
						if (TouchControl.ballmodecounter == 10) {
								++TouchControl.shootingballmode;
								TouchControl.ballmodecounter = 0;
						}
						int ballindex = (TouchControl.shootingballmode - 1) * 10 + TouchControl.ballmodecounter;
						GameObject.Find ("BallCalc").GetComponent<BallCalc> ().BallCalcChange (ballindex);
				} else {
			GameObject.Find ("BallCalc").GetComponent<BallCalc> ().BallCalcChange (40);
				}


		//TODO:update UI counter
		checkit = true;
		Debug.Log ("the total ball num is"+TouchControl.ballnumber);
		GameObject.Destroy(transform.parent.gameObject);
		Instantiate (aftercollison,transform.parent.position,transform.parent.rotation);
		Transform tmp = (Transform)Instantiate (number,transform.position+new Vector3(0,0.6f,0),number.rotation);
		Debug.Log ("the pos of tmp is "+tmp.position);
	}

	void OnGUI (){
		GUI.color = Color.black;
		GUI.skin.label.fontSize = 30;
		if (pyramid_change.checkit){
						GUI.Label(new Rect(Screen.width/2+25,0,100,100),"+3");
						InvokeRepeating("numberdisappear",1.0f,1.0f);
		}
	}
	void numberdisappear(){
				CancelInvoke ("numberdisappear");
				pyramid_change.checkit = false;
		}

}
