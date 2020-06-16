using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    public static int score = 0;
	void Start () {
        score = 0;
	}
    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}
