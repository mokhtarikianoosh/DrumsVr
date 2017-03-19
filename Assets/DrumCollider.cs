using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider c){

		if (c.name == "Snare") {
			
			Debug.Log ("Just hit Snare");

		}
	}
}
