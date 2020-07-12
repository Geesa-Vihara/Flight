using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pausemenu : MonoBehaviour {
	public GameObject pausemen,pausebutn;
	public Text timertext;


	public void Pause(){
		pausemen.SetActive (true);
		pausebutn.SetActive (false);
		Time.timeScale = 0;

	}
	public void Resume(){
		pausemen.SetActive (false);
		pausebutn.SetActive (true);
		Time.timeScale = 1;
	}
	public void Restart(){
		Time.timeScale = 1;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	


	}
	public void LoadMenu(){
		Time.timeScale = 1;
		SceneManager.LoadScene ("main menu");
	}
}