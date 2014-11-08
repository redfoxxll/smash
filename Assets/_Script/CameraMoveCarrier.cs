using UnityEngine;
using System.Collections;

public class CameraMoveCarrier : MonoBehaviour {
	[HideInInspector]
	public bool cameramove;
	public float cameraspeed;

	public static int distance;
	void Start () {
		distance = 0;
		cameramove = false;
	}
	
	void Update () {
//		if (cameramove)       need to be added in the end
		{
				transform.Translate (0, 0, cameraspeed * Time.deltaTime);
				distance++;
		}
	}
}
