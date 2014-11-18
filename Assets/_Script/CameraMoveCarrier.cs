using UnityEngine;
using System.Collections;

public class CameraMoveCarrier : MonoBehaviour {
	[HideInInspector]
	public bool cameramove;
	public float cameraspeed;

	public static int distance;
	private bool cameraoutcontrol;

	void Start () {
		distance = 0;
		cameramove = false;
		cameraoutcontrol = false;
	}
	void Update () {
		if (!TouchControl.gameover) {
				if (cameramove) {        // need to be added in the end
						transform.Translate (0, 0, cameraspeed * Time.deltaTime);
						distance++;
				}
			} else {
			cameraspeed *= 0.9f;

			if(cameraspeed * Time.deltaTime >=0.05f )
			transform.Translate (0, 0, cameraspeed * Time.deltaTime);
			else if(cameraspeed * Time.deltaTime < 0.05f&&!cameraoutcontrol)
			{
				transform.Translate (0, 0, 0);
				cameraoutcontrol = true;
				transform.FindChild("Main Camera").GetComponent<Animator>().SetTrigger("cameraoutscene");
			}
		}
	}
}
