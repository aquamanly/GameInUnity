using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public string xaxis;
	public string yaxis;
	public string pickup;
	public string plug;

	public int HP;

	public float playerSpeed;
	public Vector2 direction;

	public int enemiesHere;
	public bool charged;

	private Rigidbody2D rb2D;

	public int internEnergy;


	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D>();
		HP = 0;
		internEnergy = 10;
	}

	// Update is called once per frame
	void Update () {

		direction.x = Input.GetAxisRaw (xaxis);
		direction.y = Input.GetAxisRaw (yaxis);
//		if (enemiesHere >= 1) {
//			Debug.Log ("The Combo Multiplier is *" + enemiesHere);
//		}
		if (internEnergy <= 0) {
			charged = false;
		}



	}

	public void ApplyDamage(int enemyDamage){
		if (charged) {
			
		

			HP = HP + (enemyDamage * enemiesHere);
			internEnergy = internEnergy - (enemyDamage * enemiesHere);
		}
	
	}

	void FixedUpdate(){

		rb2D.velocity = new Vector2(direction.x * playerSpeed, direction.y * playerSpeed);
	}

	void OnTriggerEnter2D(Collider2D enemiesCollided){
		
			
		
			if (enemiesCollided.gameObject.CompareTag ("Enemy")) {
			
				Debug.Log ("in");
				ApplyDamage (1);
				enemiesPresent (true);

		}
	}


	void OnTriggerExit2D(Collider2D enemiesCollided){
		if (enemiesCollided.gameObject.CompareTag ("Enemy")) {
			
			Debug.Log ("out");
			ApplyDamage (0);
			enemiesPresent (false);
		}

	}

	//detects if enemies are touching you.
	//This helps with multipliers.
	void enemiesPresent(bool areThey){
		if (areThey) {
			enemiesHere = enemiesHere + 1;
		} else if (!areThey) {
			enemiesHere = enemiesHere - 1;
		}


	}
}
