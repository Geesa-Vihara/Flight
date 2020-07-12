using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour {

	public GameObject gamewinpanel;

	void OnCollisionEnter2D(Collision2D col){
		if (col.transform.CompareTag ("Player")) {
			gamewinpanel.SetActive (true);
			Time.timeScale = 0;
		}
	}
}