using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class dying : MonoBehaviour {	
	
	[SerializeField]Transform spawnpoint;
	public static int reloadnum;
	public GameObject gameoverpanel;
	public static int value=3;
	public Text score;
	public Button restart,restart1,restart2;


	void Start(){
		score.text= value.ToString();
		gameoverpanel.SetActive (false);

		Button btn = restart.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		Button btn1 = restart1.GetComponent<Button>();
		btn1.onClick.AddListener(TaskOnClick);
		Button btn2 = restart2.GetComponent<Button>();
		btn2.onClick.AddListener(TaskOnClick);
			}
	void TaskOnClick()
	{
		value = 3;
		reloadnum = 0;
	}

	void OnCollisionEnter2D(Collision2D col){
		
		if(col.transform.CompareTag("Player")){
		   col.transform.position = spawnpoint.position;
			value = value - 1;
			if (reloadnum < 2) {
				reloadnum++;
				SceneManager.LoadScene (SceneManager.GetActiveScene ().name);


			} 
			else {
				score.text= value.ToString();
				gameoverpanel.SetActive(true);
				Time.timeScale = 0;
			}
	}
	}



	}

