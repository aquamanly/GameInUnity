using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CablePlug : MonoBehaviour {

	public GameObject cablePrefab;
	public GameObject wallOutlet1;
	public GameObject wallOutlet2;
	public GameObject wallOutlet3;
	public GameObject lastCable1;
	public GameObject lastCable2;
	public GameObject lastCable3;
	public float length = 9.208f;
	public string plugIn;
	public bool nearOutlet1;
	public bool nearOutlet2;
	public bool nearOutlet3;
	public bool nearCable1;
	public bool nearCable2;
	public bool nearCable3;
	public bool cablePlugged;

	// Use this for initialization
	void Start () {
		cablePlugged = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (cablePlugged && nearOutlet1 && Input.GetButtonDown (plugIn)) {

			cablePlugged = false;
			Destroy (gameObject.GetComponent<HingeJoint2D>());
			Destroy (gameObject.GetComponent<DistanceJoint2D> ());
			wallOutlet1.AddComponent<HingeJoint2D> ();
			wallOutlet1.GetComponent<HingeJoint2D> ().connectedBody = lastCable1.GetComponent<Rigidbody2D> ();
			Debug.Log ("Unplugged!");
			return;
		}

		if (cablePlugged && nearOutlet2 && Input.GetButtonDown (plugIn)) {

			cablePlugged = false;
			Destroy (gameObject.GetComponent<HingeJoint2D>());
			Destroy (gameObject.GetComponent<DistanceJoint2D> ());
			wallOutlet2.AddComponent<HingeJoint2D> ();
			wallOutlet2.GetComponent<HingeJoint2D> ().connectedBody = lastCable2.GetComponent<Rigidbody2D> ();
			Debug.Log ("Unplugged!");
			return;
		}

		if (cablePlugged && nearOutlet3 && Input.GetButtonDown (plugIn)) {

			cablePlugged = false;
			Destroy (gameObject.GetComponent<HingeJoint2D>());
			Destroy (gameObject.GetComponent<DistanceJoint2D> ());
			wallOutlet3.AddComponent<HingeJoint2D> ();
			wallOutlet3.GetComponent<HingeJoint2D> ().connectedBody = lastCable3.GetComponent<Rigidbody2D> ();
			Debug.Log ("Unplugged!");
			return;
		}

		//---------------------------------------

		if (!cablePlugged && nearCable1 && Input.GetButtonDown (plugIn)) {
			
			cablePlugged = true;
			Destroy (wallOutlet1.GetComponent<HingeJoint2D> ());
			gameObject.AddComponent<HingeJoint2D> ();
			gameObject.GetComponent<HingeJoint2D> ().connectedBody = lastCable1.GetComponent<Rigidbody2D> ();
			gameObject.AddComponent<DistanceJoint2D> ();
			gameObject.GetComponent<DistanceJoint2D> ().connectedBody = wallOutlet1.GetComponent<Rigidbody2D> ();
			gameObject.GetComponent<DistanceJoint2D> ().maxDistanceOnly = true;
			gameObject.GetComponent<DistanceJoint2D> ().autoConfigureDistance = false;
			gameObject.GetComponent<DistanceJoint2D> ().distance = length;
//			wallOutlet1.AddComponent<HingeJoint2D> ();
//			wallOutlet1.GetComponent<HingeJoint2D> ().connectedBody = lastCable.GetComponent<Rigidbody2D> ();
			Debug.Log ("Plugged!");
			return;
		}

		if (!cablePlugged && nearCable2 && Input.GetButtonDown (plugIn)) {

			cablePlugged = true;
			Destroy (wallOutlet2.GetComponent<HingeJoint2D> ());
			gameObject.AddComponent<HingeJoint2D> ();
			gameObject.GetComponent<HingeJoint2D> ().connectedBody = lastCable2.GetComponent<Rigidbody2D> ();
			gameObject.AddComponent<DistanceJoint2D> ();
			gameObject.GetComponent<DistanceJoint2D> ().connectedBody = wallOutlet2.GetComponent<Rigidbody2D> ();
			gameObject.GetComponent<DistanceJoint2D> ().maxDistanceOnly = true;
			gameObject.GetComponent<DistanceJoint2D> ().autoConfigureDistance = false;
			gameObject.GetComponent<DistanceJoint2D> ().distance = length;
//			wallOutlet2.AddComponent<HingeJoint2D> ();
//			wallOutlet2.GetComponent<HingeJoint2D> ().connectedBody = lastCable.GetComponent<Rigidbody2D> ();
			Debug.Log ("Plugged!");
			return;
		}

		if (!cablePlugged && nearCable3 && Input.GetButtonDown (plugIn)) {

			cablePlugged = true;
			Destroy (wallOutlet3.GetComponent<HingeJoint2D> ());
			gameObject.AddComponent<HingeJoint2D> ();
			gameObject.GetComponent<HingeJoint2D> ().connectedBody = lastCable3.GetComponent<Rigidbody2D> ();
			gameObject.AddComponent<DistanceJoint2D> ();
			gameObject.GetComponent<DistanceJoint2D> ().connectedBody = wallOutlet3.GetComponent<Rigidbody2D> ();
			gameObject.GetComponent<DistanceJoint2D> ().maxDistanceOnly = true;
			gameObject.GetComponent<DistanceJoint2D> ().autoConfigureDistance = false;
			gameObject.GetComponent<DistanceJoint2D> ().distance = length;
//			wallOutlet3.AddComponent<HingeJoint2D> ();
//			wallOutlet3.GetComponent<HingeJoint2D> ().connectedBody = lastCable.GetComponent<Rigidbody2D> ();
			Debug.Log ("Plugged!");
			return;
		}

	}

	void OnTriggerEnter2D (Collider2D other){
		
		if (other.tag == "Outlet1") {
			nearOutlet1 = true;
			Debug.Log ("nearoutlet!");
		}
		if (other.tag == "Outlet2") {
			nearOutlet2 = true;
			Debug.Log ("nearoutlet!");
		}
		if (other.tag == "Outlet3") {
			nearOutlet3 = true;
			Debug.Log ("nearoutlet!");
		}

		if (other.tag == "LastCable1") {
			nearCable1 = true;
		}

		if (other.tag == "LastCable2") {
			nearCable2 = true;
		}

		if (other.tag == "LastCable3") {
			nearCable3 = true;
		}

	}

	void OnTriggerExit2D (Collider2D other){

		if (other.tag == "Outlet1") {
			nearOutlet1 = false;
		}
		if (other.tag == "Outlet2") {
			nearOutlet2 = false;
		}
		if (other.tag == "Outlet3") {
			nearOutlet3 = false;
		}
		if (other.tag == "LastCable1") {
			nearCable1 = false;
		}

		if (other.tag == "LastCable2") {
			nearCable2 = false;
		}

		if (other.tag == "LastCable3") {
			nearCable3 = false;
		}
	}

}
