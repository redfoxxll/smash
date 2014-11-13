using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

public class BallCalc : MonoBehaviour {
//	public Texture2D ball0;
//	public Texture2D ball1;
//	public Texture2D ball2;
//	public Texture2D ball3;
//	public Texture2D ball4;
//	public Texture2D ball5;
//	public Texture2D ball6;
//	public Texture2D ball7;
//	public Texture2D ball8;
//	public Texture2D ball9;
//	public Texture2D ball10;
//	public Texture2D ball11;
//	public Texture2D ball12;
//	public Texture2D ball13;
//	public Texture2D ball14;
//	public Texture2D ball15;
//	public Texture2D ball16;
//	public Texture2D ball17;
//	public Texture2D ball18;
//	public Texture2D ball19;
//	public Texture2D ball20;
//	public Texture2D ball21;
//	public Texture2D ball22;
//	public Texture2D ball23;
//	public Texture2D ball24;
//	public Texture2D ball25;
//	public Texture2D ball26;
//	public Texture2D ball27;
//	public Texture2D ball28;
//	public Texture2D ball29;
//	public Texture2D ball30;
//	public Texture2D ball31;
//	public Texture2D ball32;
//	public Texture2D ball33;
//	public Texture2D ball34;
//	public Texture2D ball35;
//	public Texture2D ball36;
//	public Texture2D ball37;
//	public Texture2D ball38;
//	public Texture2D ball39;
//	public Texture2D ball40;

	public Texture2D[] balltexture;
//	public Texture2D ball1_2;
//	public Texture2D ball1_3;
//	public Texture2D ball1_4;
//	public Texture2D ball1_5;

	// Use this for initialization
	void Start () {
//		balltexture = new Texture2D[41];
//		for (int i = 0; i<41; i++) 
//		{
//			string tmp = "ball"+i;
//			FieldInfo tmptexture = this.GetType().GetField(tmp);
////			Texture2D tmp1 = this.GetType().GetProperty(tmp);
//			balltexture[i] = (Texture2D)tmptexture.GetValue(this);
//		}
	}
	public void BallCalcChange(int i)
	{
		guiTexture.texture = balltexture[i];

	}
	// Update is called once per frame
	void Update () {
	
	}
}
