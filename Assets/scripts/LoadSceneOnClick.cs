using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {

	public void LoadByIndex(int sceneIndex)
	{
		SceneManager.LoadScene (sceneIndex);
		dying dying = GetComponent<dying>();
		dying.value = 3;
		dying.reloadnum = 0;

	}
}