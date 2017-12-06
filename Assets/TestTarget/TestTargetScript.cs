using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTargetScript : MonoBehaviour {
	public bool Running {
		get; 
		private set;
	}

	// Use this for initialization
	void Start () {
		Running = true;	
	}
	
}
