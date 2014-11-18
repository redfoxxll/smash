using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

public class BallCalc : MonoBehaviour {
	public GUISkin mySkin;
	public Texture2D[] balltexture;
	public void BallCalcChange(int i)
	{
		guiTexture.texture = balltexture[i];
	}

	void OnGUI () {
				if(mySkin) 
					GUI.skin = mySkin;
		if(TouchControl.ballnumber>=0)
			GUI.Label(new Rect(Screen.width/2+20,20,100,100), TouchControl.ballnumber.ToString());
		else
			GUI.Label(new Rect(Screen.width/2+20,20,100,100),"0");
	}
}
