using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    private bool ballInPlay;
    public GameObject ball;

	// Use this for initialization
	void Start () {
        ballInPlay = false;
        reset();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void reset()
    {
        Instantiate(ball, transform.position, transform.rotation);
    }
}
