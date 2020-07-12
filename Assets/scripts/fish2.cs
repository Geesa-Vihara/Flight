using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish2 : MonoBehaviour {
	public float delta=17.0f;
	public float speed = 2.0f;

	private Vector3 StartPos;

	// Use this for initialization
	void Start () {
		StartPos = transform.position;

	}

	// Update is called once per frame
	void Update () {
		Vector3 v = StartPos;
		v.y = v.y + delta * Mathf.PingPong (Time.time, 0.5f);
		transform.position = v;

	}
}
