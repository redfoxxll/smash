using UnityEngine;
using System.Collections;

public class diamond_change : MonoBehaviour {
	public Transform aftercollison;
	public Transform number;
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
		TouchControl.ballnumber += 5;
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

		GameObject.Destroy(transform.parent.gameObject);
		Instantiate (aftercollison,transform.parent.position,transform.parent.rotation);
		Instantiate (number,transform.position+new Vector3(0,1.5f,-1.5f),number.rotation);
	}

}
