using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class terbang : MonoBehaviour {

    public GameObject GCanvas;
    public float velocity = 1;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        GCanvas.SetActive(false);
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
	}
    void OnCollisionEnter2D(Collision2D Colli)
    {
        Time.timeScale = 0;
        GCanvas.SetActive(true);
    }
}
