﻿using UnityEngine;
using System.Collections;

public class DeathFloor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(){
		GameManager.OnRespawn();
	}
}
