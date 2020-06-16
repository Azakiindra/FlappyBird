using UnityEngine;
using System.Collections;

public class kenacoll : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D EnterScore)
    {
        Score.score++;
    }
}
