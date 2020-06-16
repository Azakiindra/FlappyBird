using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ulangi : MonoBehaviour {

	public void OnButtonClick(){
		SceneManager.LoadScene(0);
		// use this if your unity under version 5.3 Application.LoadLevel(Application.loadedLevel);
	}
}
