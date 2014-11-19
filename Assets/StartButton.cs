using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
//	void Update ()
//	void onMouseDown()
	void OnGUI()
	{
		if (Input.GetMouseButtonDown (0) && !TouchControl.touchable) {
//		if (!TouchControl.touchable) {
			transform.parent.GetComponent<Animator> ().SetTrigger ("cameraenterscene");
			GameObject.Destroy(gameObject);
	    }
	}
}
