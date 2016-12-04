using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour {
	public float speed=.2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x>=30)
		transform.Translate(-speed,0,0);
		else
		{
			transform.Translate(40,0,0);
				}
	}
}
