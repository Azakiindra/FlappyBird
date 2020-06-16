using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject GameObjectCanvas;
	// Use this for initialization
	void Start ()
    {
        GameObjectCanvas.SetActive(false);
        Time.timeScale = 1;
	}
	
	// Update is called once per frame

    public void GameOver()
    {
        GameObjectCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}
