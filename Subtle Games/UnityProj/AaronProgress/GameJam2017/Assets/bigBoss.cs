using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigBoss : MonoBehaviour {


	NPC thisBoss = new NPC();
	public string role =  "CEO";

	public float rechargeRate = 10f;
	public float battLvl;


	// Use this for initialization
	void Start () {
		
		thisBoss.name = "Jeremy";
		thisBoss.title = "CEO";
		//string role = thisBoss.titleHeld[0].ToString();



	}
	
	// Update is called once per frame
	void Update () {
		
		//thisBoss.killMe ();
	}



	void OnTriggerEnter2D (Collider2D guy){
		if (guy.gameObject.CompareTag("Player")) {
			Debug.Log ("Kill me");
			guy.gameObject.SendMessage ("ApplyDamage");


		}
	}

}
