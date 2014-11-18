using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TouchControl : MonoBehaviour {
	public Transform oneball;
	public Transform twoball;
	public Transform threeball;
	public Transform fourball;
	public Transform fiveball;

	public int forcefactor;
	//TODO:serialize the record
	public static int shootingballmode;
	public static int ballnumber;
	public static int ballmodecounter;
	public static bool gameover;

	public float horizonforce;
	public float verticalforce;
	public float forwardforce;

	public GUISkin mySkin;
	
	static public bool touchable;
//	private Queue<Transform> stagecreate;
	private Transform shootingball;
	// Use this for initialization
	void Start () {
//		stagecreate = new Queue<Transform> ();
		shootingballmode = 1;
		ballnumber = 25;
		ballmodecounter = 0;
		touchable = false;
		gameover = false;
	}
	public void detector()
	{
		Debug.Log ("contacted");
	}
	void Update () {
		if (Input.GetMouseButtonDown (0)&&(TouchControl.ballnumber > 0)&&touchable) {
			float forcex = (Input.mousePosition.x -  Screen.width/2)/(Screen.width/2);
			float forcey = (Input.mousePosition.y -  Screen.height/2)/(Screen.height/2);

			switch(shootingballmode){
			case 1:
				shootingball = (Transform)Instantiate(oneball,Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2,Screen.height/2,Camera.main.nearClipPlane)),oneball.rotation);
				Debug.Log ("the ball z is "+shootingball.position+Camera.main.name);
				foreach(Transform ballchild in shootingball)
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce,forcey*verticalforce,forwardforce),ForceMode.Acceleration);
				}
				break;
			case 2:
				shootingball = (Transform)Instantiate(twoball,Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2,Screen.height/2,Camera.main.nearClipPlane)),twoball.rotation);
				int i = 0;
				foreach(Transform ballchild in shootingball)
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce+(20.0f*i),forcey*verticalforce,forwardforce),ForceMode.Acceleration);
					i++;
				}
				break;
			case 3:
				shootingball = (Transform)Instantiate(threeball,Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2,Screen.height/2,Camera.main.nearClipPlane)),twoball.rotation);

			foreach(Transform ballchild in shootingball)
			{
				if(ballchild.tag=="topball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce,forcey*verticalforce+5.0f,forwardforce),ForceMode.Acceleration);
				}else if(ballchild.tag=="leftball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce-10.0f,forcey*verticalforce-15.0f,forwardforce),ForceMode.Acceleration);	
				}else if(ballchild.tag=="rightball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce+10.0f,forcey*verticalforce-15.0f,forwardforce),ForceMode.Acceleration);
				}
			}
				break;
			case 4:
				shootingball = (Transform)Instantiate(fourball,Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2,Screen.height/2,Camera.main.nearClipPlane)),twoball.rotation);
			foreach(Transform ballchild in shootingball)
			{
				if(ballchild.tag=="topball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce,forcey*verticalforce+5.0f,forwardforce),ForceMode.Acceleration);
				}else if(ballchild.tag=="downball")
				{  
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce,forcey*verticalforce-15.0f,forwardforce),ForceMode.Acceleration);	
				}else if(ballchild.tag=="rightball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce+10.0f,forcey*verticalforce-5.0f,forwardforce),ForceMode.Acceleration);
				}else if(ballchild.tag=="leftball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce-10.0f,forcey*verticalforce-5.0f,forwardforce),ForceMode.Acceleration);
				}
			}
				break;
			case 5:
				shootingball = (Transform)Instantiate(fiveball,Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2,Screen.height/2,Camera.main.nearClipPlane)),twoball.rotation);
			foreach(Transform ballchild in shootingball)
			{
				if(ballchild.tag=="topleftball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce-10.0f,forcey*verticalforce+5.0f,forwardforce),ForceMode.Acceleration);
				}else if(ballchild.tag=="toprightball")
				{  
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce+10.0f,forcey*verticalforce+5.0f,forwardforce),ForceMode.Acceleration);	
				}else if(ballchild.tag=="middleball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce,forcey*verticalforce-5.0f,forwardforce),ForceMode.Acceleration);
				}else if(ballchild.tag=="downleftball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce-10.0f,forcey*verticalforce-15.0f,forwardforce),ForceMode.Acceleration);
				}else if(ballchild.tag=="downrightball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce+10.0f,forcey*verticalforce-15.0f,forwardforce),ForceMode.Acceleration);
				}
			}
				break;
			}

			if(--TouchControl.ballnumber <= 0)
			{
				ballnumber = 0;
				//TODO:game over
				Debug.Log("game over");
				gameover = true;
			}
		}
	}
}
