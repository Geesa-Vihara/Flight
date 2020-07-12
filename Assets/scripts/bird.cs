using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {

	[SerializeField]
	private Transform pointA;
	[SerializeField]
	private Transform pointB;
	[SerializeField]
	private float speed;

	private void Awake()
	{
		transform.position = pointA.position;
	}

	private void Update()
	{
		if (transform.position==pointB.position) 
			transform.position = pointA.position;

		float step = speed * Time.deltaTime;

		transform.position = Vector3.MoveTowards(transform.position, pointB.position, step);
	}
}