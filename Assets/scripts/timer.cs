using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {
	public Text timertext;
	static float starttime=10.00f;
	public float t;
	public GameObject gameoverpanel;

	void awake(){
		Time.timeScale = 1;
	}


	// Use this for initialization
	void Start () {
		
		timertext.text="10.00";

		}


	void Update () {
		
	    t = starttime- Time.time;
		string seconds = (t % 60).ToString("f2");
		timertext.text = seconds;
		if (t<=0) {
			timertext.text="Time Up!";
			Time.timeScale=0;



		}
					}


	
	}
	

