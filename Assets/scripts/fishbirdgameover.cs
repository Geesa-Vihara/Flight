using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fishbirdgameover : MonoBehaviour {
	public GameObject gameoverpanel;

	void OnCollisionEnter2D(Collision2D col){
		if (col.transform.CompareTag ("Player")) {
			gameoverpanel.SetActive (true);
			Time.timeScale = 0;
		}
	}
}
