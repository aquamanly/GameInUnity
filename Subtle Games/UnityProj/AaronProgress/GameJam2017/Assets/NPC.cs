using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC{
	enum titles
	{
		CEO ,
		EMPLYEE,
		JANITOR,
		VISITOR,
	}
	public string name;
	public string title;
	public string[] titleHeld = { "tom", "dick", "harry" };
	public int wiiFii;
	static int whyfi;
	int wifi;



	public void killMe(){
		Debug.Log ("Yolo");
	}




}
