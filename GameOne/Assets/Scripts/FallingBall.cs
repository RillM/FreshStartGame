﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBall : MonoBehaviour {
 
  
	public float speed =.5f;
 
    void Start() {
        
    }

        // Update is called once per frame
        void Update () {
		transform.Translate(-speed,0,0);
        }
    
}