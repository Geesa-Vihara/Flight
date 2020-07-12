using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane : MonoBehaviour {
	public float movespeed;
	public float yforce;
	public float xforce;
	public Rigidbody2D rb;
	private const float ROTATION_MIN = -135F;
	private const float ROTATION_MAX = 40F;
	public float rotationspeed = 1f;


	void Start () {
	}

	void Update () {

		Vector3 currentrotation = this.transform.eulerAngles;
		float inputinfluence = 0;		 

		if (Input.GetKey ("up")) {
			inputinfluence += this.rotationspeed;
			if (yforce <= 700) { 	
				yforce += 10f;
			}
		}
		if (Input.GetKey ("down")) {
			inputinfluence -= this.rotationspeed;			
			if(yforce >=-1170) {	
				yforce -= 10f;
			}
		}
		if (yforce < 710.0f) {
			xforce = -600.0f;
		}

		if (yforce > -1180.0f) {
			xforce = -600.0f;
		}
		if (yforce == 710.0f) {
			xforce = 0.0f;
		}
		if (yforce== -1180.0f) {
			xforce = 0.0f;
		}
		currentrotation.z = currentrotation.z % 360;
		if (currentrotation.z > 180) {
			currentrotation.z -= 360f;
		}
		currentrotation.z=Mathf.Clamp(currentrotation.z+inputinfluence,ROTATION_MIN,ROTATION_MAX);
		this.transform.rotation=Quaternion.Euler(currentrotation);

		if (Input.GetKeyUp (KeyCode.Space)) {

			rb.gravityScale = 1;
			rb.AddForce (new Vector2(xforce,yforce));
			xforce=0f;
		}
	}
}