using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public string xaxis;
	public string yaxis;
	//public string item;

	public float itemTime;
	public bool isFaster = true;
	public bool fasterEffect = true;

	public float playerSpeed;
	public Vector2 direction;

	private Rigidbody2D rb2D;


	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
		direction.x = Input.GetAxisRaw (xaxis);
		direction.y = Input.GetAxisRaw (yaxis);




	}

	void FixedUpdate(){
		
		rb2D.velocity = new Vector2(direction.x * playerSpeed, direction.y * playerSpeed);
}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Item"){
			Destroy (other.gameObject);

		}
	}



}



	 


