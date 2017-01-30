using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectWifi : MonoBehaviour {

	public GameObject boss;
	public float wifipower;
	public Sprite[] here= new Sprite[4];


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (wifipower > 10) {

			wifipower =  boss.GetComponent<GettenDemPoints> ().batteryLevel;
			
			this.GetComponent<SpriteRenderer> ().sprite = here [0];
		} else if (wifipower > 20 && wifipower< 100) {
			this.GetComponent<SpriteRenderer> ().sprite = here[1];
		} else if (wifipower > 50 && wifipower< 100) {
			this.GetComponent<SpriteRenderer> ().sprite = here[2];
		} else if (wifipower > 100 && wifipower< 100) {
			this.GetComponent<SpriteRenderer> ().sprite = here[3];
		}
	}
}
