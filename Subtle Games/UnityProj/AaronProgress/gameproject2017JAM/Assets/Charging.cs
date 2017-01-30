using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charging : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other){
		other.GetComponent<Movement> ().charged = true;
		other.GetComponent<Movement> ().internEnergy = 20;

	}
}
