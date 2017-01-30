using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

	public Vector3 pointB;
	public float speed;
	public Vector3 pointC;
	//this line of code, the array,
	//needs work to be better implimented
	//somehow we can use an for loop somehow
	public Vector3[] points;

	IEnumerator Start(){
		Vector3 pointA = transform.position;


		while (true) {
			yield return MoveObject (transform, pointA, pointB);
			yield return MoveObject (transform, pointB, pointC);
			yield return MoveObject (transform, pointC, pointB);
			yield return MoveObject (transform, pointB, pointA);
		}
	}

	IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos){
		float i = 0.0f;

		while (i < 1.0f) {
			i += Time.deltaTime * speed;
			thisTransform.position = Vector3.Lerp (startPos, endPos, i);
			yield return null;
		}
	}
}