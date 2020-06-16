using UnityEngine;
using System.Collections;

public class panggilan : MonoBehaviour {

    public float MaxTime = 1;
    private float time = 0;
    public GameObject pipa;
    public float height;

	// Use this for initialization
	void Start () {
        GameObject pipabaru = Instantiate(pipa);
        pipabaru.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
	}
	
	// Update is called once per frame
	void Update () {
	    if(time > MaxTime)
        {
            GameObject pipabaru = Instantiate(pipa);
            pipabaru.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(pipabaru, 15);
            time = 0;
        }

        time += Time.deltaTime;

	}
}
