using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettenDemPoints : MonoBehaviour {

	public float rechargeRate = 10.0F;
	public float batteryLevel;
	public GameObject theEffectedNPC;

	void OnTriggerStay2D (Collider2D guy){
		if (guy.GetComponent<Movement> ().charged = true) {
			
		

			if (batteryLevel < 100) {
				if (guy.gameObject.CompareTag ("Player")) {
					//Debug.Log ("Kill me");
					batteryLevel = Mathf.Min (batteryLevel + rechargeRate * Time.deltaTime, 100.0F);

					if (batteryLevel < 0) {
						theEffectedNPC.GetComponent<SpriteRenderer> ().sprite = 
						theEffectedNPC.GetComponent <CollectWifi> ().here [3];
					}
					if (batteryLevel > 50) {
						theEffectedNPC.GetComponent<SpriteRenderer> ().sprite = 
					theEffectedNPC.GetComponent <CollectWifi> ().here [2];
					}
					if (batteryLevel > 75) {
						theEffectedNPC.GetComponent<SpriteRenderer> ().sprite = 
						theEffectedNPC.GetComponent <CollectWifi> ().here [1];
					}
					if (batteryLevel == 100) {
						theEffectedNPC.GetComponent<SpriteRenderer> ().sprite = 
						theEffectedNPC.GetComponent <CollectWifi> ().here [0];
					}

				}
			}
		}
	}
}
